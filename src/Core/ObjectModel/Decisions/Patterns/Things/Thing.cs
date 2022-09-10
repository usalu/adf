using System;
using System.Collections.Generic;
using System.Numerics;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things
{
    public class Thing: Instance
    {
        public ThingType ThingType;

        public Plane Orientation { get; }

        public Thing(ThingType thingType, Plane? orientation = null, string name = "", IEnumerable<string>? concepts = null,
            Dictionary<string, object>? parameters = null): base(name, concepts, parameters)
        {
            ThingType = thingType ?? throw new ArgumentNullException(nameof(thingType));
            Orientation = orientation ?? new Plane(0,0,1,0);
        }

        ////Produces an ambiguous constructor
        //public Thing(ThingType thingType, string name = "", string concept = "",
        //    Dictionary<string, object>? parameters = null) : base(name, concept, parameters)
        //{
        //    ThingType = thingType ?? throw new ArgumentNullException(nameof(thingType));
        //}


    }
}
