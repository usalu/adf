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
    public class Pattern2D : Pattern
    {
        public Dictionary<Thing, Vector2> Embedding { get; }
        public Vector3 PrimaryOrientation { get; }
        public Vector3 SecondaryOrientation { get; }

        public Pattern2D(IEnumerable<Thing> things, IEnumerable<Relation> relations,
            Dictionary<Thing, Vector2> embedding, Vector3 primaryOrientation, Vector3 secondaryOrientation) : base(
            things, relations)
        {
            Embedding = embedding ?? throw new ArgumentNullException(nameof(embedding));
            PrimaryOrientation = primaryOrientation;
            SecondaryOrientation = secondaryOrientation;
        }
    }
}
