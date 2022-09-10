using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern2D : Pattern
    {
        public Dictionary<Thing, Vector2> Embedding { get; }

        public Surface Space;

        public Pattern2D(Surface space, Dictionary<Thing, Vector2> embedding, IEnumerable<Thing> things,
            IEnumerable<Relation>? relations = null) : base(things, relations)
        {
            Space = space ?? throw new ArgumentNullException(nameof(space));
            Embedding = embedding ?? throw new ArgumentNullException(nameof(embedding));
        }
    }
}
