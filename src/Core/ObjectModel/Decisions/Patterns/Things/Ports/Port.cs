using System.Collections.Generic;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports;

public abstract class Port: Instance
{
    protected Port(string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(name, concepts, parameters)
    {
    }
}