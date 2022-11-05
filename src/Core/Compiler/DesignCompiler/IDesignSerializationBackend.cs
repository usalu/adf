using DDF.Core.ObjectModel;

namespace DDF.Core.Compiler.Backends
{
    /// <summary>
    /// Functionality to serialize designs.
    /// This is useful for either saving designs or sending it to the frontend (not very efficient but sufficient for the moment).
    /// </summary>
    public interface IDesignSerializationBackend
    {
        string Serialize(Design design);
    }
}
