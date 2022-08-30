using DDF.Core.Decisions;
using DDF.Core.Relations;
using DDF.Core.Things;
using System.Net.Http.Headers;
using System.Numerics;
using DDF.Core.Decisions.Patterns;
using DDF.Core.Designs.Patterns;
using DDF.Core.Ports;

namespace DDF.Core.UnitTests
{
    [TestClass]
    public class SchlenkerToolShed
    {
        private Design toolShed;

        [TestInitialize]
        public void SchlenkerToolShedInitialize()
        {

            var design = new Thing("Design");



            //var roof = new Thing("Roof");
            //var mainPart = new Thing("MainPart");
            //var basePlate = new Thing("BasePlate");

            //var designDecision = new Decision(
            //    new Pattern1D(new List<Thing>() { design }, new List<Relation>(),
            //        new Dictionary<Thing, double>() { { design, 0 } }, Vector3.UnitZ),
            //    new Pattern1D(new List<Thing>() { roof, mainPart, basePlate }, new List<Relation>() { },
            //        new Dictionary<Thing, double>() { { basePlate, 0 }, { mainPart, 1 }, { roof, 2 } }, Vector3.UnitZ),
            //    new List<Decision>());

            //var mainPartDecision = new Decision(new Pattern1D(new List<Thing>(){}) )

          
            //nbm - Normal base module
            var sidePortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var shortPortBaseModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var mitterPortBaseModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), new Dictionary<string, object>() { { "Length", 77.8f } });
            var longPortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var baseModuleType = new ThingType("BaseModule", new List<Port>() { sidePortBaseModule, shortPortBaseModule, mitterPortBaseModule, longPortBaseModule });

            //Short base module
            var sidePortShortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var shortPortShortBaseModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var mitterPortShortBaseModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), new Dictionary<string, object>() { { "Length", 77.8f } });
            var longPortShortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var shortBaseModuleType = new ThingType("ShortBaseModule", new List<Port>() { sidePortShortBaseModule, shortPortShortBaseModule, mitterPortShortBaseModule, longPortShortBaseModule });

            //Base module


            //Basic L-module
            var basicLModuleType = new ThingType("BasicLModule");

            var basicLModuleShort = new Thing(basicLModuleType, concepts: new List<string>() { "Short" });
            var basicLModuleLong = new Thing(basicLModuleType, concepts: new List<string>() { "Long" });
            var basicLModuleShortLong = new Thing(basicLModuleType, concepts: new List<string>() { "Short", "Long" });

            // lmsd: lModuleShortDecision
            var left_lmsd = new Thing(shortBaseModuleType);
            var right_lmsd = new Thing(shortBaseModuleType);
            var lmsd = new Decision(
                new Pattern1D(basicLModuleShort),
                new Pattern2D(new List<Thing>(){ left_lmsd, right_lmsd },
                    new List<Relation>(){new AssemblyRelation(left_lmsd,right_lmsd, mitterPortBaseModule, mitterPortBaseModule) }));

            toolShed = new Design("Schlenker tool shed",new List<Decision>()
            {
                
            });
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

       
    }
}