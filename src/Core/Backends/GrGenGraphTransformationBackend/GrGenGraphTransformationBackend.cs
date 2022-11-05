using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
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
                foreach (var thing in decision.Modification.Things) classes.Add(thing.TypeName);
            }

            var designGraph = new GraphModel("designGraph",
                modelUsage: new List<GraphModel>() { designGraphLibraryModel }, classDeclarations: classes.Select(x => (ClassDeclaration)new NodeClass(x, new []{new NodeClass("DesignNode")})));

            
            var graphModels = new List<GraphModel>() { designGraphLibraryModel,designGraph };

            var snippets = new List<Snippet>();
            snippets.Add(new Snippet(@"rule init { modify { d:" + decisions.First().Context.Things.First().TypeName + @"; } }"));
            snippets.AddRange(decisions.Select(GetDefaultRewrittingRuleSnipped));

            //RuleSet ruleSet = new RuleSet("designGraph", new FileHeader(graphModels), decisions.Select(GetRewrittingRule));
            RuleSet ruleSet = new RuleSet("designGraph", new FileHeader(graphModels), snippets: snippets);

            CompileSet compileSet = new CompileSet(graphModels, ruleSet);


            //Dynamically compile and instantiate
            _wrapper.Initialize(compileSet);

            //Apply all sequences
            _wrapper.Apply("init");
            _wrapper.Apply(new LazyGreedyAndListRewriteSequence(_ruleNames));

            //Translate back
            GraphTranslator translator = new GraphTranslator();


            throw new NotImplementedException();
        }

        GraphModel GetLibrary()
        {
            return new GraphModel("designGraphLibrary",
                new List<Snippet>()
                {
                    new Snippet(@"abstract node class DesignNode { filled: boolean; } undirected edge class connected;")
                });
        }

        Rule GetRewrittingRule(Decision decision)
        {
            throw new NotImplementedException();
        }

        Snippet GetDefaultRewrittingRuleSnipped(Decision decision)
        {
            string firstLevelWhiteSpaces = "    ";
            string secondLevelWhiteSpaces = "        ";

            string typeName = decision.Context.Things.First().TypeName;
            var thingsTypeNameRHS = decision.Modification.Things.Select(x => x.TypeName).ToArray();
            var thingsRHS = decision.Modification.Things.Select(x => x.Guid).ToArray();
            var relationsRHS = decision.Modification.Relations;

            Dictionary<Guid,string> variableNamesMap = new Dictionary<Guid, string>();

            var variableNames = new List<string>();
            for (int i = 0; i < thingsRHS.Length; i++)
            {
                var variableName = "x" + i;
                variableNamesMap[thingsRHS[i]]=variableName;
                variableNames.Add(secondLevelWhiteSpaces + variableName);
            }

            var variableDeclarations = new List<string>();
            for (int i = 0; i < thingsRHS.Length; i++) variableDeclarations.Add(variableNames[i] + ":" + thingsTypeNameRHS[i] + ";");

            var relationDeclarations = new List<string>();
            foreach (var relation in relationsRHS)
            {
                relationDeclarations.Add( variableNamesMap[relation.Relating.Guid] + " -:connected- " + variableNamesMap[relation.Related.Guid] + ";");
            }

            string ruleName = typeName + "DefaultRule";
            _ruleNames.Add(ruleName);
            string snippet = "rule " + ruleName + @" { d:" + typeName + @"; if { d.filled==false; } modify {" + "\n" + string.Join("\n", variableDeclarations) +
                string.Join("\n", relationDeclarations) + "eval { d.filled=true; } } }";
            return new Snippet(snippet);
        }
    }
}
