using System;
using System.Collections.Generic;

namespace DDF.Core.ObjectModel
{
    public abstract class Instance: ICloneable
    {
        public IEnumerable<string> Concepts { get; }
        public CloneableDictionary<string, ICloneable> Parameters { get; }

        protected Instance(IEnumerable<string>? concepts = null, CloneableDictionary<string, ICloneable>? parameters = null)
        {
            Concepts = concepts ?? new List<string>();
            Parameters = parameters ?? new CloneableDictionary<string, ICloneable>();
        }
        public abstract object Clone();
    }
}
