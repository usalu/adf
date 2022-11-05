using System;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using GrGenWrapper.ObjectModel;
using GrGenWrapper.ObjectModel.RuleSets.Actions;

namespace DDF.Core.Compiler.GGXBBackend
{
    public class GrGenGraphTransformationBackend : IGraphTransformationBackend
    {

        public IGeometryBackend GeometryBackend { get; }
        public ObjectModel.Graphs.Graph TransformGraph(DecisionSequence decisionSequence, ObjectModel.Graphs.Graph startingGraph = null)
        {
            throw new NotImplementedException();
        }

        Rule GetRewrittingRule(Decision decision)
        {
            throw new NotImplementedException();
        }
    }
}
