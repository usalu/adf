using System.Collections.Generic;
using System.Numerics;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports;

public class Port2D : Port
{
    public Vector2 Origin;
    public Vector2 Direction;

    public Port2D(Vector2 origin, Vector2 direction, string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(name, concepts, parameters)
    {
        Origin = origin;
        Direction = direction;
    }
}