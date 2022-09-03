using System.Collections.Generic;
using System.IO;
using DDF.Core.Compiler.GGXBBackend;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.UnitTests;

[TestClass]
public class CompilerTest
{
    Compiler.Compiler _compiler;
    [TestInitialize]
    public void CompilerInitialize()
    {
        _compiler = new Compiler.Compiler(new GGXBBackend());
    }

    [TestMethod]
    public void CompilePipeline()
    {
        string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen\Easy";
            //string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\DDF-Core-Compiler\";
            = Directory.GetFiles(folder, @"*.gm");

        string fileName = "schuppen";
        ruleFilePath = Path.Combine(folder, fileName + ".grg");
        string shellFilePath = Path.Combine(folder, fileName + ".grs");

        var result = _compiler.Compile(new Design("TestDesign", new List<Decision>()));
    }
}