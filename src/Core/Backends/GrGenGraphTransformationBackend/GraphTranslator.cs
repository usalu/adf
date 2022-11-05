using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel.Graphs;
using GrGenWrapper.Wrappers.Graphs;

namespace DDF.Core.Compiler.GGXBBackend
{
    internal class GraphTranslator
    {
        internal SemanticalSkeleton Translate(GrGenWrapper.Wrappers.Graphs.Graph graph)
        {
            return new SemanticalSkeleton();
        }

        internal GrGenWrapper.Wrappers.Graphs.Graph Translate(SemanticalSkeleton skeleton)
        {
            return new GrGenWrapper.Wrappers.Graphs.Graph();
        }
    }
}
