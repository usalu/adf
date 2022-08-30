using System.Numerics;

namespace DDF.Core;

public static class Utility
{
    /// <summary>
    /// Get a plane from x,y,z rotations.
    /// </summary>
    /// <param name="xRotation">Rotation around the x-axis in degree.</param>
    /// <param name="yRotation">Rotation around the y-axis in degree.</param>
    /// <param name="zRotation">Rotation around the z-axis in degree.</param>
    public static Plane GetPlaneFromRotations(float xRotation = 0, float yRotation = 0, float zRotation = 0) =>
        Plane.Transform(
            //Unit plane
            Plane.CreateFromVertices(
                new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1)),
            //Rotation quaternion
            Quaternion.CreateFromYawPitchRoll(
                DegToRad(xRotation), DegToRad(yRotation), DegToRad(zRotation)));

    /// <summary>
    /// Convert degree angle to radiant angle
    /// </summary>
    /// <param name="a">angle in degree</param>
    /// <returns></returns>
    public static float DegToRad(float a) => (float)(Math.PI / 180 * a);

}