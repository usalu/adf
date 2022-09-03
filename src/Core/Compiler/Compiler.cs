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
using DDF.Core.ObjectModel;
using Microsoft.CSharp;


namespace DDF.Core.Compiler
{
    public class Compiler
    {
        public IBackend Backend;

        public Compiler(IBackend backend)
        {
            Backend = backend;
        }

        public string Compile(Design design)
        {
            return Backend.GetIfc(design);
        }
    }
}