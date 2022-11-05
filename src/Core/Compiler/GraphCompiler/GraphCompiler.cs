using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection;
using DDF.Core.Compiler.Backends;
using DDF.Core.ObjectModel;
using Microsoft.CSharp;


namespace DDF.Core.Compiler
{
    public class GraphCompiler
    {
        ISerializationBackend SerializationBackend { get; }

        public string Compile(ObjectModel.DecisionSequence design)
        {
            throw new NotImplementedException();
        }
    }
}