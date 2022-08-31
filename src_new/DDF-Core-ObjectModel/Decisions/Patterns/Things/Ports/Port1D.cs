using System;
using System.Collections.Generic;
using System.Numerics;

namespace DDF.Core.Ports
{
    public class Port1D : Port
    {
        /// <summary>
        /// One dimensional origin point
        /// </summary>
        public Double Origin;

        public Port1D(double origin, string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(name, concepts, parameters)
        {
            Origin = origin;
        }
    }
}
