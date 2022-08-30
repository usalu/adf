using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.Designs.Patterns;
using DDF.Core.Relations;
using DDF.Core.Things;

namespace DDF.Core.Decisions.Patterns
{
    public class Pattern3D : Pattern
    {
        public Dictionary<Thing, Vector3> Embedding { get; }
        public Vector3 PrimaryOrientation { get; }
        public Vector3 SecondaryOrientation { get; }
        public Vector3 TertiaryOrientation { get; }

        public Pattern3D(IEnumerable<Thing> things, IEnumerable<Relation> relations,
            Dictionary<Thing, Vector3> embedding, Vector3 primaryOrientation, Vector3 secondaryOrientation,
            Vector3 tertiaryOrientation) : base(things, relations)
        {
            Embedding = embedding ?? throw new ArgumentNullException(nameof(embedding));
            PrimaryOrientation = primaryOrientation;
            SecondaryOrientation = secondaryOrientation;
            TertiaryOrientation = tertiaryOrientation;
        }
    }
}
