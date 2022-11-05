using System.Collections.Generic;
using System.IO;
using DDF.Core.Compiler;
using DDF.Core.Compiler.Decisions;
using DDF.Core.Compiler.GGXBBackend;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.UnitTests;

[TestClass]
public class CompilerTest
{
    private DecisionCompiler _decisionCompiler;

    [TestInitialize]
    public void DecisionsCompilerInitialize()
    {
        _decisionCompiler = new DecisionCompiler(new GrGenGraphTransformationBackend());
    }
    [TestInitialize]
    public void CompilerInitialize()
    {
       
    }

    [TestMethod]
    public void CompilePipeline()
    {
    }
}