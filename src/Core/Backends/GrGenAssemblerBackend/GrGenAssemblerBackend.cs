using System;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using GrGenWrapper.ObjectModel;
using GrGenWrapper.ObjectModel.RuleSets.Actions;

namespace DDF.Core.Compiler.GGXBBackend
{
    public class GrGenAssemblerBackend : IAssemblerBackend
    {
        public IGeometryBackend GeometryBackend { get; }
        public Design Assemble(DesignPlan designPlan)
        {
            //var compileSet = new CompileSet();
            //GrGenWrapper.GrGenWrapper.CreateGraphProcessingEnvironment(compileSet);
            throw new NotImplementedException();
        }

        Rule GetRewrittingRule(Decision decision)
        {
            throw new NotImplementedException();
        }

    }
}
