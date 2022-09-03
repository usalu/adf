using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern2D : Pattern
    {
        public Dictionary<Thing, Vector2> Embedding { get; }
        public Vector3 PrimaryOrientation { get; }
        public Vector3 SecondaryOrientation { get; }

        public Pattern2D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null,
            Dictionary<Thing, Vector2>? embedding = null, Vector3? primaryOrientation = null, Vector3? secondaryOrientation = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, Vector2>();
            PrimaryOrientation = primaryOrientation ?? Vector3.UnitX;
            SecondaryOrientation = secondaryOrientation ?? Vector3.UnitY;

            //TODO: Extend checking to checking linear dependency
            if (primaryOrientation==secondaryOrientation)
                throw new ArgumentException("Primary and secondary orientation can't be linear dependent because otherwise they are a 1D Pattern.");

        }

      
    }
}
