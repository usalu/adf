using System.Numerics;

namespace DDF.Core.Ports;

public class Port3D : Port
{
    public Vector3 Origin;
    public Vector3 Direction;
    public Vector3 Normal;

    public Port3D(Vector3 origin, Vector3 direction, Vector3 normal, string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(name, concepts, parameters)
    {
        Origin = origin;
        Direction = direction;
        Normal = normal;
    }
}