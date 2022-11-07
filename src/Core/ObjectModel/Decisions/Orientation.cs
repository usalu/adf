using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations
{
    /// <summary>
    /// Describes a relational orientation inside a three dimensional space.
    /// </summary>
    public struct Orientation
    {
        /// <summary>
        /// Coordinates of the location.
        /// </summary>
        public Vector3 Point { get; }
        /// <summary>
        /// Describes the rotation factor alpha in degree of the tangent plane according right hand rule.
        /// The tangent plane has the tangent of u as x vector and tangent of v as y vector.
        /// </summary>
        public double Alpha { get; }
        /// <summary>
        /// Describes the rotation factor gamma in degree of the tangent plane according right hand rule.
        /// The tangent plane has the tangent of u as x vector and tangent of v as y vector.
        /// </summary>
        public double Gamma { get; }

        public Orientation(Vector3 point = default, double alpha = 0, double gamma=0)
        {
            Point = point;
            Alpha = alpha;
            Gamma = gamma;
        }

        public Orientation(Vector2 point = default, double alpha = 0, double gamma = 0)
        {
            Point = new Vector3(point,0);
            Alpha = alpha;
            Gamma = gamma;
        }

        public Orientation(float x = 0, double alpha = 0, double gamma = 0)
        {
            Point = new Vector3(x,0, 0);
            Alpha = alpha;
            Gamma = gamma;
        }
    }
}
