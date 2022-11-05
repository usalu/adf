using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Numerics;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using DDF.Core.ObjectModel.Decisions.Patterns;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Decisions.Patterns.Things.Ports;

namespace DDF.Core.UnitTests
{
    [TestClass]
    public class SchlenkerToolShed
    {

        [TestInitialize]
        public void SchlenkerToolShedInitialize()
        {

            var design = new Module("Design");

            //var roof = new Thing("Roof");
            //var mainPart = new Thing("MainPart");
            //var basePlate = new Thing("BasePlate");

            //var designDecision = new Decision(
            //    new Pattern1D(new [],
            //        new Dictionary<Thing, double>() { { design, 0 } }, Vector3.UnitZ),
            //    new Pattern1D(new [] { },
            //        new Dictionary<Thing, double>() { { basePlate, 0 }, { mainPart, 1 }, { roof, 2 } }, Vector3.UnitZ),
            //    new []);

            //var mainPartDecision = new Decision(new Pattern1D(new []{}) )

          
            ////nbm - Normal base module
            //var sidePortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var shortPortBaseModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var mitterPortBaseModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), parameters: new Dictionary<string, object>() { { "Length", 77.8f } });
            //var longPortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var baseModuleType = new Module("BaseModule", new [] { sidePortBaseModule, shortPortBaseModule, mitterPortBaseModule, longPortBaseModule });

            ////Short base module
            //var sidePortShortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var shortPortShortBaseModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var mitterPortShortBaseModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), parameters: new Dictionary<string, object>() { { "Length", 77.8f } });
            //var longPortShortBaseModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), parameters: new Dictionary<string, object>() { { "Length", 110f } });
            //var shortBaseModuleType = new Module("ShortBaseModule", new [] { sidePortShortBaseModule, shortPortShortBaseModule, mitterPortShortBaseModule, longPortShortBaseModule });

            ////Basic L-module
            //var basicLModuleType = new Module("BasicLModule");

            //var basicLModuleShort = new Thing(basicLModuleType, concepts: new [] { "Short" });
            //var basicLModuleLong = new Thing(basicLModuleType, concepts: new [] { "Long" });
            //var basicLModuleShortLong = new Thing(basicLModuleType, concepts: new [] { "Short", "Long" });


            //// lmsd: lModuleShortDecision
            //var left_lmsd = new Thing(shortBaseModuleType);
            //var right_lmsd = new Thing(shortBaseModuleType);
            //var lmsd = new Decision(
            //    new Pattern1D(basicLModuleShort),
            //    new Pattern2D(new []{ left_lmsd, right_lmsd },
            //        new [] {new Relation(left_lmsd, left_lmsd) },
            //        new Dictionary<Thing, Vector2>(){ { left_lmsd, new Vector2(0,1)},{right_lmsd, new Vector2(1,0)} }));

            //// lmld: lModuleLongDecision
            //var left_lmld = new Thing(shortBaseModuleType);
            //var right_lmld = new Thing(shortBaseModuleType);
            //var lmld = new Decision(
            //    new Pattern1D(basicLModuleShort),
            //    new Pattern2D(new [] { left_lmld, right_lmld },
            //        new [] { new Relation(left_lmld, left_lmld) },
            //        new Dictionary<Thing, Vector2>() { { left_lmld, new Vector2(0, 1) }, { right_lmld, new Vector2(1, 0) } }));

            //toolShed = new DesignPlan("Schlenker tool shed",new []
            //{
            //    lmsd,lmld
            //});
        }


    }
}