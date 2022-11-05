using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern3D : Pattern
    {
        public Dictionary<Thing, Vector3> Embedding { get; }
        public Space3D Space { get; }

        public Pattern3D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null,
            Dictionary<Thing, Vector3>? embedding = null, Space3D? space = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, Vector3>();
            Space = space ?? Space3D.EuclideanXYZ;
        }
    }
}
