using System.Collections.Generic;
using DDF.Core.Ports;

namespace DDF.Core.Things;

public class ThingType
{
    public string Name { get; }
    public IEnumerable<Port>? Ports { get; }

    public ThingType(string name, IEnumerable<Port>? ports = null)
    {
        Name = name;
        Ports = ports ?? new List<Port>();
    }
}