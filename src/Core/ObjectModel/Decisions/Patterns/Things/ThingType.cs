using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things;

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