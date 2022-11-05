using System;
using System.Collections.Generic;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports
{
    public class Port1D : Port
    {
        /// <summary>
        /// One dimensional origin point
        /// </summary>
        public Double Origin;

        public Port1D(double origin)
        {
            Origin = origin;
        }
    }
}
