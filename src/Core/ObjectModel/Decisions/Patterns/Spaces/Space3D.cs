using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Spaces
{
    /// <summary>
    /// A three dimensional topological space. Mainly it will be the euclidean R³ but it doesn't have to be.
    /// </summary>
    public abstract class Space3D: Space
    {
        public abstract Vector3 EvaluateAt(double x, double y, double z);
    }
}
