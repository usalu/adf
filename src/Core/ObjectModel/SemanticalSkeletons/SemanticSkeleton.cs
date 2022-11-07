using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.ObjectModel.Graphs
{
    public class SemanticSkeleton
    {
        public IEnumerable<Thing> Things { get; }
        public IEnumerable<Relation> Relations { get; }
        public Dictionary<Thing, Orientation> Embedding { get; }

        public SemanticSkeleton(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null, Dictionary<Thing, Orientation>? embedding = null)
        {
            Things = things ?? throw new ArgumentNullException(nameof(things));
            Relations = relations ?? new List<Relation>();
            Embedding = embedding ?? new Dictionary<Thing, Orientation>();
        }
    }
}
