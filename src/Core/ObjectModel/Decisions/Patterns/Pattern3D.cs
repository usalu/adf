using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern3D : Pattern
    {
        public Dictionary<Thing, Vector3> Embedding { get; }
        public Vector3 PrimaryOrientation { get; }
        public Vector3 SecondaryOrientation { get; }
        public Vector3 TertiaryOrientation { get; }

        public Pattern3D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null, Dictionary < Thing, Vector3>? embedding = null, 
            Vector3? primaryOrientation = null, Vector3? secondaryOrientation = null, Vector3? tertiaryOrientation = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, Vector3>();
            PrimaryOrientation = primaryOrientation ?? Vector3.UnitX;
            SecondaryOrientation = secondaryOrientation ?? Vector3.UnitY;
            TertiaryOrientation = tertiaryOrientation ?? Vector3.UnitZ;
        }
    }
}
