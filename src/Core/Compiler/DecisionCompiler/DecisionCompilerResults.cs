using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel.Graphs;

namespace DDF.Core.Compiler.Graph
{
    public class DecisionCompilerResults
    {
        public DecisionCompilerResults(SemanticSkeleton semanticSkeleton)
        {
            SemanticSkeleton = semanticSkeleton;
        }

        public SemanticSkeleton SemanticSkeleton { get; }
    }
}
