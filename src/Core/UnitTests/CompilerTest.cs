using System.Collections.Generic;
using System.IO;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.UnitTests;

[TestClass]
public class CompilerTest
{
    GraphCo
    [TestInitialize]
    public void CompilerInitialize()
    {
        _compiler = new Compiler.Compiler(new GGXBBackend());
    }

    [TestMethod]
    public void CompilePipeline()
    {
     
    }
}