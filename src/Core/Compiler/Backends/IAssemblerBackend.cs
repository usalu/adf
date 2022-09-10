using DDF.Core.ObjectModel;

namespace DDF.Core.Compiler.Backends
{
    /// <summary>
    /// Functionality to assemble the design from design plans.
    /// </summary>
    public interface IAssemblerBackend
    {
        /// <summary>
        /// Geometric functionality needed during design assembling process.
        /// </summary>
        IGeometryBackend GeometryBackend { get; }
        /// <summary>
        /// Assemble the plan
        /// </summary>
        /// <param name="designPlan"></param>
        /// <returns></returns>
        Design Assemble(DesignPlan designPlan);
    }
}
