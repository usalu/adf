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

        public Pattern1D(IEnumerable<Thing> things, IEnumerable<Relation> relations,
            Dictionary<Thing, string[]> concepts, Dictionary<Thing, double> embedding, Vector3 primaryOrientation) :
            base(things, relations, concepts)
        {
            Embedding = embedding ?? throw new ArgumentNullException(nameof(embedding));
            PrimaryOrientation = primaryOrientation;
        }
    }
}
