using System.Numerics;

namespace DDF.Core.Ports;

public class Port3D : Port
{
    public Vector3 Origin;
    public Vector3 Direction;
    public Vector3 Normal;

    public Port3D(Vector3 origin, Vector3 direction, Vector3 normal)
    {
        Origin = origin;
        Direction = direction;
        Normal = normal;
    }
}