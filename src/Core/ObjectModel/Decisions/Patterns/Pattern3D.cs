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

        public Pattern3D(Dictionary<Thing, Vector3> embedding, Space3D space, IEnumerable<Thing> things,
            IEnumerable<Relation>? relations = null) : base(things, relations)
        {
            Embedding = embedding ?? throw new ArgumentNullException(nameof(embedding));
            Space = space ?? throw new ArgumentNullException(nameof(space));
        }
    }
}
