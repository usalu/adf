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

            var sidePortShortModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var shortPortShortModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var mitterPortShortModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), new Dictionary<string, object>() { { "Length", 77.8f } });
            var longPortShortModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });

            var shortModule = new Thing("ShortModule", new List<Port>() { sidePortShortModule, shortPortShortModule, mitterPortShortModule, longPortShortModule });

            var sidePortModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var shortPortModule = new Port2D(new Vector2(55, 55), new Vector2(1, 0), new Dictionary<string, object>() { { "Length", 110f } });
            var mitterPortModule = new Port2D(new Vector2(82.5f, 55), new Vector2(1, 1), new Dictionary<string, object>() { { "Length", 77.8f } });
            var longPortModule = new Port2D(new Vector2(0, 55), new Vector2(-1, 0), new Dictionary<string, object>() { { "Length", 110f } });

            var module = new Thing("Module", new List<Port>() { sidePortModule, shortPortModule, mitterPortModule, longPortModule });


            Design schuppen = new Design("Schlenker tool shed",new List<Decision>()
            {
                
            });
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

       
    }
}