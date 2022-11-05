using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things;

public class Module
{
    public string Name { get; }
    public IEnumerable<Port>? Ports { get; }

    public Module(string name, IEnumerable<Port>? ports = null)
    {
        Name = name;
        Ports = ports ?? new List<Port>();
    }
}