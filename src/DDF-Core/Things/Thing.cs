

using DDF.Core.Ports;

namespace DDF.Core.Things;

public class Thing
{
    public string Type { get; }
    public IEnumerable<Port>? Ports { get; }

    public Thing(string type, IEnumerable<Port>? ports = null)
    {
        Type = type ?? throw new ArgumentNullException(nameof(type));
        Ports = ports ?? new List<Port>();
    }
}