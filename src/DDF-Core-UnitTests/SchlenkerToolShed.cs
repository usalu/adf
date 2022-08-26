using System.Net.Http.Headers;

namespace DDF.Core.UnitTests
{
    [TestClass]
    public class SchlenkerToolShed
    {

        [TestInitialize]
        public void SchlenkerToolShedInitialize()
        {
            var roof = new Thing("Roof");
            var mainPart = new Thing("MainPart");
            var basePlate = new Thing("BasePlate");

            Project schuppen = new Project("Schlenker tool shed", new List<Decision>()
            {
                new Decision( 
                    new Design(new List<Thing>()
                    {
                        new Thing("Design")
                    }),
                    new Design( new List<Thing>()
                        {
                            roof, mainPart, basePlate
                        },
                        new List<View>()
                        {
                            new PositionalView(
                                new List<Relation>()
                                {
                                    new Relation( roof,"above",mainPart),
                                    new Relation(mainPart,"above",basePlate)
                                })
                        }))
            });
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

       
    }
}