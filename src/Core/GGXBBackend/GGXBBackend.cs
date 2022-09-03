using System;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using GrGenWrapper.ObjectModel;
using GrGenWrapper.ObjectModel.RuleSets.Actions;

namespace DDF.Core.Compiler.GGXBBackend
{
    public class GGXBBackend : IBackend
    {
        public string GetIfc(Design design)
        {
           var compileSet = new CompileSet();

           GrGenWrapper.GrGenWrapper.CreateGraphProcessingEnvironment(compileSet);
        }

        Rule GetRewrittingRule(Decision decision)
        {
            
        }

    }
}
