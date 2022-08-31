using DDF.Core.Things;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.Designs.Patterns;
using DDF.Core.Relations;

namespace DDF.Core.Decisions.Patterns
{
    public class Pattern1D : Pattern
    {
        public Dictionary<Thing, Double> Embedding { get; }
        public Vector3 PrimaryOrientation { get; }

        public Pattern1D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null, Dictionary<Thing, double>? embedding = null, Vector3? primaryOrientation = null ) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, double>();
            PrimaryOrientation = primaryOrientation ?? Vector3.UnitX;
        }

        public Pattern1D(Thing thing):this(new List<Thing>(){thing})
        {
           
        }
    }
}
