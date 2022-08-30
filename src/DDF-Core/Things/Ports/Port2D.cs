using System.Numerics;

namespace DDF.Core.Ports;

public class Port2D : Port
{
    public Vector2 Origin;
    public Vector2 Direction;

    public Port2D(Vector2 origin, Vector2 direction, Dictionary<string, object>? parameters = null, IEnumerable<string>? concepts = null) : base(parameters, concepts)
    {
        Origin = origin;
        Direction = direction;
    }
}