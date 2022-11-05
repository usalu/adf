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
    public class SemanticalSkeleton
    {
        public IEnumerable<Thing> Things;
        public IEnumerable<Relation> Relations;
        public Dictionary<Thing, Orientation3D> Embedding;
       
    }
}
