using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs;
using GrGenWrapper;
using GrGenWrapper.ObjectModel;
using GrGenWrapper.ObjectModel.GraphModels;
using GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations;
using GrGenWrapper.ObjectModel.RuleSets;
using GrGenWrapper.ObjectModel.RuleSets.Actions;
using GrGenWrapper.Wrappers.RewriteSequences;

namespace DDF.Core.Compiler.GGXBBackend
{
    public class GrGenGraphTransformationBackend : IGraphTransformationBackend
    {
        private Wrapper _wrapper;

        private List<string> _ruleNames;

        public GrGenGraphTransformationBackend()
        {
            _wrapper = new Wrapper();
            _ruleNames = new List<string>();
        }

        public SemanticalSkeleton TransformGraph(List<Decision> decisions, SemanticalSkeleton startingGraph = null)
        {
            //Get static library code
            var designGraphLibraryModel = GetLibrary();

            //Build dynamic model 
            HashSet<string> classes = new HashSet<string>();
            foreach (var decision in decisions)
            {
                foreach (var thing in decision.Context.Things) classes.Add(thing.TypeName);
                foreach (var thing in decision.ModifiedContext.Things) classes.Add(thing.TypeName);
            }

            var designGraph = new GraphModel("designGraph",
                modelUsage: new List<GraphModel>() { designGraphLibraryModel }, classDeclarations: classes.Select(x => (ClassDeclaration)new NodeClass(x, new []{new NodeClass("DesignNode")})));

            
            var graphModels = new List<GraphModel>() { designGraphLibraryModel,designGraph };

            //RuleSet ruleSet = new RuleSet("designGraph", new FileHeader(graphModels), decisions.Select(GetRewrittingRule));
            var snippets = new List<Snippet>();
            snippets.Add(new Snippet("\nfunction getU(var alpha:double, var gamma:double): Vector { def var x:double = Math::cos(alpha)*Math::cos(alpha); " +
                                     "def var y:double = Math::sin(alpha)*Math::cos(gamma); def var z:double = Math::sin(gamma); return( new Vector@(x=x, y=y, z=z)); } "));
            snippets.Add(new Snippet(@"rule init { modify { d:" + decisions.First().Context.Things.First().TypeName + @";" +
                                     "\neval{d.o = new Orientation@(p=new Vector@(x = 0,y=0,z=0), alpha = 0, gamma= 0); } } }"));
            snippets.AddRange(decisions.Select(GetDefaultRewrittingRuleSnipped));
            RuleSet ruleSet = new RuleSet("designGraph", new FileHeader(graphModels), snippets: snippets);

            CompileSet compileSet = new CompileSet(graphModels, ruleSet);


            //Dynamically compile and instantiate
            _wrapper.Initialize(compileSet);

            //Apply all sequences
            _wrapper.Apply("init");
            _wrapper.Apply(new LazyGreedyAndListRewriteSequence(_ruleNames));
            _wrapper.Show();

            //Translate back
            GraphTranslator translator = new GraphTranslator();


            throw new NotImplementedException();
        }

        GraphModel GetLibrary()
        {
            return new GraphModel("designGraphLibrary",
                new List<Snippet>()
                {
                    new Snippet( "class Vector { x:double; y: double; z: double;}" + "\nclass Orientation { p:Vector; alpha:double; gamma:double;}" +
                                 "\nabstract node class DesignNode { filled: boolean; o: Orientation; }" +
                                 "\nundirected edge class connected;")
                });
        }

        Rule GetRewrittingRule(Decision decision)
        {
            throw new NotImplementedException();
        }

        Snippet GetDefaultRewrittingRuleSnipped(Decision decision)
        {
            

            string typeName = decision.Context.Things.First().TypeName;
            var thingsRHS = decision.ModifiedContext.Things.ToArray();
            var thingsTypeNameRHS = decision.ModifiedContext.Things.Select(x => x.TypeName).ToArray();
            var thingsGuidRHS = decision.ModifiedContext.Things.Select(x => x.Guid).ToArray();

            var relationsRHS = decision.ModifiedContext.Relations;

            Dictionary<Guid,string> variableNamesMap = new Dictionary<Guid, string>();

            var variableNames = new List<string>();
            for (int i = 0; i < thingsGuidRHS.Length; i++)
            {
                var variableName = "x" + i;
                variableNamesMap[thingsGuidRHS[i]]=variableName;
                variableNames.Add(variableName);
            }

            var variableDeclarations = new List<string>();
            for (int i = 0; i < thingsGuidRHS.Length; i++) variableDeclarations.Add(variableNames[i] + ":" + thingsTypeNameRHS[i] + ";");


            var nodeInitialValues = new List<string>();
            for (int i = 0; i < thingsGuidRHS.Length; i++)
            {
                var orientation = decision.ModifiedContext.Embedding[thingsRHS[i]];
                nodeInitialValues.Add(variableNames[i] + ".o = new Orientation@(p=new Vector@(x = d.o.p.x + "+ orientation.Point.X +
                                      ",y = d.o.p.y + " + orientation.Point.Y + ",z = d.o.p.y + " + orientation.Point.Z + 
                                      "), alpha = d.o.alpha +" + orientation.Alpha + ", gamma= d.o.gamma + " + orientation.Alpha +"); ");
            }

            var relationDeclarations = new List<string>();
            foreach (var relation in relationsRHS)
            {
                relationDeclarations.Add( variableNamesMap[relation.Relating.Guid] + " -:connected- " + variableNamesMap[relation.Related.Guid] + ";");
            }

            string ruleName = typeName + "DefaultRule";
            _ruleNames.Add(ruleName);

            string replacementMechanism =
                decision.DecisionMechanism == DecisionMechanism.Destruction ? "replace" : "modify";

            string snippet = "rule " + ruleName + "{ d:" + typeName + "; if { d.filled==false; }\n" + replacementMechanism +"{" + string.Join("\n", variableDeclarations) +
                string.Join("\n", relationDeclarations) + "\neval { d.filled=true; "+ string.Join("\n", nodeInitialValues) +" } } }";
            return new Snippet(snippet);
        }
    }
}
