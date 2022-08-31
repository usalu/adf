using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core
{
    public abstract class Instance
    {
        public string Name { get; }
        public IEnumerable<string> Concepts { get; }
        public Dictionary<string, object> Parameters { get; }

        protected Instance(string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null)
        {
            Name = name;
            Concepts = concepts ?? new List<string>();
            Parameters = parameters ?? new Dictionary<string, object>();
        }
    }
}
