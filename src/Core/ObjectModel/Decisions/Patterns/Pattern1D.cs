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

        public Pattern1D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null,
            Dictionary<Thing, double>? embedding = null, Curve? space = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, double>();
            Space = space ?? Curve.NormalizedXLine;
        }
        public Pattern1D(Thing thing) : this(new List<Thing>(){thing})
        {
        }
    }
}
