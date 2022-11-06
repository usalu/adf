using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.ObjectModel.Decisions.Patterns
{
    public class Pattern1D : Pattern
    {

        public Dictionary<Thing, Double> Embedding{ get; }
        public Curve Space { get; }


        public Pattern1D(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null,
            Dictionary<Thing, double>? embedding = null) : base(things, relations)
        {
            Embedding = embedding ?? new Dictionary<Thing, double>();
           
        }
        public Pattern1D(Thing thing) : this(new List<Thing>(){thing})
        {
        }
        
    }
}
