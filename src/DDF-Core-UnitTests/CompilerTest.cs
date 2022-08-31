using System.Collections.Generic;
using DDF.Core.Decisions;

namespace DDF.Core.UnitTests;

[TestClass]
public class CompilerTest
{
    private Compiler.Compiler compiler;
    [TestInitialize]
    public void CompilerInitialize()
    {
        compiler = new Compiler.Compiler();
    }

    [TestMethod]
    public void CompilePipeline()
    {
        var result = compiler.Compile(new Design("TestDesign", new List<Decision>()));
    }
}