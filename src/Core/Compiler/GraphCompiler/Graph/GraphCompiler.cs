using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;

namespace DDF.Core.Compiler.Graph
{
    public class GraphCompiler
    {
        public GraphCompiler(IGraphTransformationBackend graphTransformationBackend)
        {
            GraphTransformationBackend = graphTransformationBackend;
        }

        IGraphTransformationBackend GraphTransformationBackend { get; }

        public GraphCompilerResults compile(DecisionSequence decisionSequence)
        {
            throw new NotImplementedException();
        }
    }
}
