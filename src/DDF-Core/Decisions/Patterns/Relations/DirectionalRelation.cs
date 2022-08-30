using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.Relations;
using DDF.Core.Things;

namespace DDF.Core.Decisions.Patterns.Relations
{
    public class DirectionalRelation:Relation
    {
        public DirectionalRelation(IEnumerable<Thing> relating, IEnumerable<Thing> related, string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(relating, related, name, concepts, parameters)
        {
        }
    }
}
