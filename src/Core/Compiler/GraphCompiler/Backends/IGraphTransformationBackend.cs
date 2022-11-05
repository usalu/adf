using DDF.Core.ObjectModel;

namespace DDF.Core.Compiler.Backends
{
    /// <summary>
    /// Functionality to assemble the design from design plans.
    /// </summary>
    public interface IGraphTransformationBackend
    {
        /// <summary>
        /// Geometric functionality needed during design assembling process.
        /// </summary>
        IGeometryBackend GeometryBackend { get; }
      /// <summary>
      /// Transforms a given graph.
      /// If there is no empty graph then there needs to be a decision with an empty RHS pattern.
      /// </summary>
      /// <param name="decisionSequence"></param>
      /// <param name="startingGraph"></param>
      /// <returns></returns>
        ObjectModel.Graphs.Graph TransformGraph(DecisionSequence decisionSequence, 
            ObjectModel.Graphs.Graph? startingGraph = null);
    }
}
