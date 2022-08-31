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
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.lgsp;
using Microsoft.CSharp;
using Xbim.Ifc;
using Xbim.IO;

namespace DDF.Core.Compiler
{
    public class Compiler
    {
        public LGSPNamedGraph Compile(Design design)
        {
            string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen\Easy";
            //string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\DDF-Core-Compiler\";
            string[] modelFilePaths = Directory.GetFiles(folder, @"*.gm");

            string fileName = "schuppen";
            string ruleFilePath = Path.Combine(folder, fileName + ".grg");
            string shellFilePath = Path.Combine(folder, fileName + ".grs");

            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Split('.').First());
            Directory.CreateDirectory(tempDirectory);
            string tempRuleFilePath = Path.Combine(tempDirectory, fileName + ".grg");
            string tempShellFilePath = Path.Combine(tempDirectory, fileName + ".grs");

            foreach (var modelFilePath in modelFilePaths)
                File.Copy(modelFilePath, Path.Combine(tempDirectory, Path.GetFileName(modelFilePath)), true);
            File.Copy(ruleFilePath, tempRuleFilePath, true);
            File.Copy(shellFilePath, tempShellFilePath, true);

            //File.Copy(@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\GrGen\lgspBackend.dll",
            //    Path.Combine(tempDirectory, "lgspBackend.dll"), true);
            //File.Copy(@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\GrGen\lgspBackend.dll",
            //    Path.Combine(tempDirectory, "lgspBackend.dll"), true);

            Process grGen = new Process();
            grGen.StartInfo.FileName = "grgen.exe";
            grGen.StartInfo.WorkingDirectory = tempDirectory;
            grGen.StartInfo.Arguments+=("-keep "); //Path.Combine(tempDirectory)+ "\\"
            grGen.StartInfo.Arguments+=("-noevents ");
            //grGen.StartInfo.ArgumentList.Add("-noperfinfo");
            grGen.StartInfo.Arguments+=(fileName + ".grg ");
            grGen.StartInfo.CreateNoWindow = true;

            try
            {
                grGen.Start();
                grGen.WaitForExit();

                string[] cSharpFiles = Directory.GetFiles(Path.Combine(tempDirectory, "tmpgrgen0"), @"*Actions.cs")
                    .Union(Directory.GetFiles(Path.Combine(tempDirectory, "tmpgrgen0"), @"*Model.cs")).ToArray();

                var results = new CSharpCodeProvider().CompileAssemblyFromFile(new CompilerParameters()
                {
                    GenerateInMemory = true,
                    ReferencedAssemblies = {"System.dll", "libGr.dll", "lgspBackend.dll" }
                }, cSharpFiles);

                Assembly modelActionsAssembly = results.CompiledAssembly;


                //GetType doesn't work somehow
                //Type type = modelActionsAssembly.GetType(fileName+"Graph");
                //Type graphType = modelAssembly.GetType("de.unika.ipd.grGen.Model_"+ fileName + "Graph");
                Type graphType = null;
                Type actionsType = null;
                bool found = false;
                foreach (Type exportedType in modelActionsAssembly.ExportedTypes)
                {
                    if (exportedType.Name == fileName + "NamedGraph")
                    {
                        graphType = exportedType;
                        if (found) break;
                        found = true;
                    }
                    if (exportedType.Name == fileName + "Actions")
                    {
                        actionsType = exportedType;
                        if (found) break;
                        found = true;
                    }
                }
                LGSPNamedGraph graph = (LGSPNamedGraph)Activator.CreateInstance(graphType, new LGSPGlobalVariables());
                LGSPActions actions = (LGSPActions)Activator.CreateInstance(actionsType, graph);
                LGSPGraphProcessingEnvironment procEnv = new LGSPGraphProcessingEnvironment(graph, actions);

                procEnv.ApplyGraphRewriteSequence("init && DesignR* && MainPartR* && MiddleR* && InfillR* && WallR_front* && WallR_default*");

                using (var dumper = new DOTDumper(@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen\Export\design.dot", "Design", VCGFlags.OrientTopToBottom | VCGFlags.Splines))
                    GraphDumper.Dump(graph, dumper);

                Porter.Export(graph,new List<string>() {@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen\Export\design.grs"});
                ////var backend = new LGSPBackend();
                ////Porter.Import(backend, new List<string>(){tempShellFilePath},)

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Directory.Delete(tempDirectory, true);

            return null;
        }



        //public LGSPNamedGraph Compile(Design design)
        //{
        //    string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen\Easy";
        //    //string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\DDF-Core-Compiler\";
        //    string[] modelFilePaths = Directory.GetFiles(folder, @"*.gm");

        //    string fileName = "schuppen";
        //    string ruleFilePath = Path.Combine(folder, fileName + ".grg");
        //    string shellFilePath = Path.Combine(folder, fileName + ".grs");

        //    string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Split('.').First());
        //    Directory.CreateDirectory(tempDirectory);
        //    string tempRuleFilePath = Path.Combine(tempDirectory, fileName + ".grg");
        //    string tempShellFilePath = Path.Combine(tempDirectory, fileName + ".grs");

        //    foreach (var modelFilePath in modelFilePaths)
        //        File.Copy(modelFilePath, Path.Combine(tempDirectory, Path.GetFileName(modelFilePath)), true);
        //    File.Copy(ruleFilePath, tempRuleFilePath, true);
        //    File.Copy(shellFilePath, tempShellFilePath, true);

        //    File.Copy(@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\GrGen\lgspBackend.dll", 
        //        Path.Combine(tempDirectory, "lgspBackend.dll"), true);
        //    File.Copy(@"C:\Git\Studium\PhD\DesignDescriptionFramework\src\GrGen\lgspBackend.dll",
        //        Path.Combine(tempDirectory, "lgspBackend.dll"), true);

        //    Process grGen = new Process();
        //    grGen.StartInfo.FileName = "grgen.exe";
        //    grGen.StartInfo.WorkingDirectory = tempDirectory;
        //    grGen.StartInfo.ArgumentList.Add(fileName + ".grg");

        //    try
        //    {
        //        grGen.Start();
        //        grGen.WaitForExit();

        //        var modelAssemblyBytes = File.ReadAllBytes(Path.Combine(tempDirectory,"lgsp-" + fileName + "Model.dll"));
        //        var modelAssembly = Assembly.Load(modelAssemblyBytes);
        //        var actionsAssemblyBytes = File.ReadAllBytes(Path.Combine(tempDirectory, "lgsp-" + fileName + "Actions.dll"));
        //        var actionsAssembly = Assembly.Load(actionsAssemblyBytes);
        //        var names = actionsAssembly.GetReferencedAssemblies();

        //        //Find Type manually as GetType doesn't work somehow
        //        //Type type = modelAssembly.GetType(fileName+"Graph");
        //        //Type graphType = modelAssembly.GetType("de.unika.ipd.grGen.Model_"+ fileName + "Graph");
        //        Type graphType = null;
        //        foreach (Type exportedType in modelAssembly.ExportedTypes)
        //        {
        //            if (exportedType.Name==fileName + "Graph")
        //            {
        //                graphType=exportedType;
        //                break;
        //            }
        //        }
        //        LGSPGraph graph = (LGSPGraph) Activator.CreateInstance(graphType, new object?[]{ new LGSPGlobalVariables() });

        //        Type actionsType = null;
        //        foreach (Type exportedType in actionsAssembly.ExportedTypes)
        //        {
        //            if (exportedType.Name == fileName + "Actions")
        //            {
        //                actionsType = exportedType;
        //                break;
        //            }
        //        }
        //        //FAILS because one in-memory assembly can't reference another one
        //        //https://stackoverflow.com/questions/454561/in-c-how-do-you-reference-types-from-one-in-memory-assembly-inside-another
        //        LGSPActions actions = (LGSPActions)Activator.CreateInstance(actionsType, new object?[] { graph });
        //        LGSPGraphProcessingEnvironment procEnv = new LGSPGraphProcessingEnvironment(graph, actions);

        //        ////var backend = new LGSPBackend();
        //        ////Porter.Import(backend, new List<string>(){tempShellFilePath},)

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    Directory.Delete(tempDirectory, true);

        //    return null;
        //}

        //------------------------------------------------------------------------------------------------------------------------


        //public LGSPNamedGraph Compile(Design design)
        //{


        //    LGSPNamedGraph graph = null;
        //    LGSPActions actions = null;

        //    string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\Examples\Schuppen";
        //    //string folder = @"C:\Git\Studium\PhD\DesignDescriptionFramework\src\DDF-Core-Compiler\";
        //    string[] modelFilePaths = Directory.GetFiles(folder, @"*.gm");

        //    string fileName = "schuppen";
        //    string ruleFilePath = Path.Combine(folder, fileName + ".grg");
        //    string shellFilePath = Path.Combine(folder, fileName + ".grs");

        //    string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Split('.').First());
        //    Directory.CreateDirectory(tempDirectory);
        //    string tempRuleFilePath = Path.Combine(tempDirectory, fileName + ".grg");
        //    string tempShellFilePath = Path.Combine(tempDirectory, fileName + ".grs");

        //    foreach (var modelFilePath in modelFilePaths)
        //        File.Copy(modelFilePath, Path.Combine(tempDirectory, Path.GetFileName(modelFilePath)), true);
        //    File.Copy(ruleFilePath, tempRuleFilePath, true);
        //    File.Copy(shellFilePath, tempShellFilePath, true);

        //    try
        //    {
        //        LGSPBackend.Instance.CreateNamedFromSpec(tempRuleFilePath, new LGSPGlobalVariables(), tempDirectory, 0, out graph, out actions);

        //        //LGSPBackend.Instance.CreateFromSpec(ruleFilePath, globalVars, "Schuppen",tempDirectory, 
        //        //    ProcessSpecFlags.NoCreateActionsAssembly,new List<string>(), out graph,out actions);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }

        //    string[] cSharpFiles = Directory.GetFiles(Path.Combine(tempDirectory, "tmpgrgen0"), @"*.cs");
        //    var results = new CSharpCodeProvider().CompileAssemblyFromFile(new CompilerParameters()
        //    {
        //        GenerateInMemory = true,
        //        ReferencedAssemblies = { "libGr","lgspBackend" }
        //    }, cSharpFiles);

        //    Directory.Delete(tempDirectory, true);

        //    LGSPGraphProcessingEnvironment procEnv = new LGSPGraphProcessingEnvironment(graph, actions);

        //    NodeType processType = graph.GetNodeType("Process");
        //    EdgeType nextType = graph.GetEdgeType("next");

        //    INode p1 = graph.AddNode(processType);
        //    INode p2 = graph.AddNode(processType);
        //    graph.AddEdge(nextType, p1, p2);
        //    graph.AddEdge(nextType, p2, p1);

        //    procEnv.ApplyGraphRewriteSequence("newRule[3] && mountRule && requestRule[5] "
        //                                      + "&& (takeRule && releaseRule && giveRule)*");


        //    return graph;
        //}

        //public IfcStore Compile(Design design)
        //{



        //    using (var model = CreateandInitModel("HelloWall"))
        //    {

        //        model.SaveAs("HelloWallIfc4.ifc", StorageType.Ifc);
        //    }
        //}
    }
}