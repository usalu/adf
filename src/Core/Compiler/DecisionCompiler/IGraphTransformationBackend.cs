using System.Collections.Generic;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using DDF.Core.ObjectModel.Graphs;

namespace DDF.Core.Compiler.Backends
{
    /// <summary>
    /// Functionality to assemble the design from design plans.
    /// </summary>
    public interface IGraphTransformationBackend
    {

        /// <summary>
        /// Transforms a given skeleton.
        /// If there is no base skeleton then there needs to be a decision with an empty RHS pattern.
        /// </summary>
        /// <param name="decisions"></param>
        /// <param name="baseSkeleton"></param>
        /// <returns></returns>
        SemanticalSkeleton TransformGraph(List<Decision> decisions, SemanticalSkeleton? baseSkeleton = null);
    }
}
