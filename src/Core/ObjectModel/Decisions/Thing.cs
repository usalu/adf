using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Things
{
    public class Thing :ICloneable
    {
        public string TypeName { get; }
        public Guid Guid { get; }
        public IEnumerable<string> Concepts { get; }
        public CloneableDictionary<string, ICloneable> Parameters { get; }

        public Thing(string typeName, IEnumerable<string>? concepts = null, CloneableDictionary<string, ICloneable>? parameters = null)
        {
            TypeName = typeName;
            Guid = Guid.NewGuid();
            Concepts = concepts ?? new List<string>();
            Parameters = parameters ?? new CloneableDictionary<string, ICloneable>();
        }
        public object Clone() => new Thing(TypeName, new List<string>(Concepts), Parameters.Clone());
    }
}
