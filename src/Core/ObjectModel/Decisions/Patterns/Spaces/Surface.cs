using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Spaces
{

    public abstract class Surface: Space
    {
        public abstract Vector3 EvaluateAt(double u, double v);
    }
}
