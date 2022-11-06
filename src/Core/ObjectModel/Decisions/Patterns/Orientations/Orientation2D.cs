using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations
{

    /// <summary>
    /// Describes a relational orientation on a surface.
    /// </summary>
    public struct Orientation2D
    {
        public Orientation2D(Vector2 point = default, double rotation = 0)
        {
            Point = point;
            Rotation = rotation;
        }

        /// <summary>
        /// UV coordinates of the location.
        /// </summary>
        public Vector2 Point { get; }
        /// <summary>
        /// Describes the rotation factor in degree of the tangent plane according right hand rule.
        /// The tangent plane has the tangent of u as x vector and tangent of v as y vector.
        /// </summary>
        public double Rotation { get; }
    }
}
