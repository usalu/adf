using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs;

namespace DesignCompiler
{
    public class DesignCompiler
    {
        public Design compile(SemanticSkeleton skeleton, IEnumerable<Module> modules,
            Dictionary<string, Module>? typeModuleMapping = null)
        {
            return new Design();
        }
    }
}
