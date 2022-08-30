using System.Numerics;

namespace DDF.Core.Ports
{
    public class Port1D : Port
    {
        /// <summary>
        /// One dimensional origin point
        /// </summary>
        public Double Origin;

        public Port1D(double origin, Dictionary<string, object>? parameters = null, IEnumerable<string>? concepts = null) : base(parameters, concepts)
        {
            Origin = origin;
        }
    }
}
