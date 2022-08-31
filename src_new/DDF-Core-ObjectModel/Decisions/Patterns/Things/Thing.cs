using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.Things
{
    public class Thing: Instance
    {
        public ThingType ThingType;
       
        public Thing(ThingType thingType, string name = "", IEnumerable<string>? concepts = null,
            Dictionary<string, object>? parameters = null): base(name, concepts, parameters)
        {
            ThingType = thingType ?? throw new ArgumentNullException(nameof(thingType));
        }

        ////Produces an ambiguous constructor
        //public Thing(ThingType thingType, string name = "", string concept = "",
        //    Dictionary<string, object>? parameters = null) : base(name, concept, parameters)
        //{
        //    ThingType = thingType ?? throw new ArgumentNullException(nameof(thingType));
        //}


    }
}
