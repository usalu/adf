using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern1D : Pattern
    {
        public Dictionary<Thing, Double> Embedding { get; }
        public Curve Space { get; }

        public Pattern1D(Dictionary<Thing, double> embedding, Curve space, IEnumerable<Thing> things, IEnumerable<Relation>? relations = null) : base(things, relations)
        {
            Embedding = embedding;
            Space = space;
        }
    }
}
