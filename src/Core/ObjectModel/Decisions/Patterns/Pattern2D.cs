using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern2D : Pattern
    {
        /// <summary>
        /// The embedding
        /// </summary>
        public Dictionary<Thing, Orientation2D> Embedding { get; }

        public Surface Space;

        public Pattern2D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null,
            Dictionary<Thing, Orientation2D>? embedding = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, Orientation2D>();
        }
    }
}
