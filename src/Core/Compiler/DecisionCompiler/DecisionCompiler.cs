using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.Compiler.Backends;
using DDF.Core.Compiler.Graph;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.Compiler.Decisions
{
    public class DecisionCompiler
    {
        private IGraphTransformationBackend _graphTransformationBackend;
        public DecisionCompiler(IGraphTransformationBackend graphTransformationBackend)
        {
            _graphTransformationBackend = graphTransformationBackend;
        }

        public DecisionCompilerResults Compile(List<Decision> decisions)
        {
            var skeleton = _graphTransformationBackend.TransformGraph(decisions);
            return new DecisionCompilerResults(skeleton);
        }
    }
}
