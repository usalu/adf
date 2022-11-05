using System;
using System.Collections.Generic;
using System.Numerics;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things
{
    public class Thing: Instance
    {
        public string TypeName { get; }
        public Guid Guid { get; }

        public Thing(string typeName, IEnumerable<string>? concepts = null, CloneableDictionary<string, ICloneable>? parameters = null) : base(concepts, parameters)
        {
            TypeName = typeName;
            Guid = Guid.NewGuid();
        }
        public override object Clone() => new Thing(TypeName, Concepts, Parameters.Clone());
    }
}
