using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Numerics;
using DDF.Core.Compiler.Decisions;
using DDF.Core.Compiler.GGXBBackend;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions;
using DDF.Core.ObjectModel.Decisions.Patterns;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.UnitTests
{
    [TestClass]
    public class SimpleSchlenkerToolShed
    {
        public List<Decision> Decisions = new List<Decision>();
        [TestInitialize]
        public void Initialize()
        {
            //Design part
            var cornerFrontLeft = new Thing("Corner", concepts: new List<string>() { "Front", "Left" });
            var cornerFrontRight = new Thing("Corner", concepts: new List<string>() { "Front", "Right" });
            var cornerBackLeft = new Thing("Corner", concepts: new List<string>() { "Back", "Left" });
            var cornerBackRight = new Thing("Corner", concepts: new List<string>() { "Back", "Right" });

            var skinFrontLeft = new Thing("Skin", concepts: new List<string>() { "Front", "Left" });
            var skinFrontRight = new Thing("Skin", concepts: new List<string>() { "Front", "Right" });
            var skinSideLeft = new Thing("Skin",  concepts: new List<string>() { "Side" });
            var skinSideRight = (Thing)skinSideLeft.Clone();
            var skinBack = new Thing("Skin", concepts: new List<string>() { "Back" });

            var entrance = new Thing("Entrance");

            var designDecision = new Decision(
                "Design",
                new Pattern(new List<Thing>()
                {
                    cornerFrontLeft, cornerFrontRight, cornerBackLeft,cornerBackRight, 
                    skinFrontLeft, skinFrontRight, skinSideLeft, skinSideRight, skinBack, entrance
                }, new List<Relation>()
                {
                    new(cornerFrontLeft,skinFrontLeft), 
                    new(skinFrontLeft, entrance),
                    new(entrance,skinFrontRight),
                    new(skinFrontRight,cornerFrontRight),
                    new(cornerFrontRight, skinSideRight),
                    new(skinSideRight, cornerBackRight),
                    new(cornerBackRight, skinBack),
                    new(skinBack,cornerBackLeft),
                    new(cornerBackLeft, skinFrontLeft),
                }, new Dictionary<Thing, Orientation>()
                {
                    {cornerFrontLeft, new Orientation()},
                    {skinFrontLeft,new Orientation(new Vector2(0.25f,0),180)},
                    {entrance,new Orientation(new Vector2(0.5f,0),180)},
                    {skinFrontRight,new Orientation(new Vector2(0.75f,0),180)},
                    {cornerFrontRight,new Orientation(new Vector2(1f,0))},
                    {skinSideRight,new Orientation(new Vector2(1f,0.5f),270)},
                    {cornerBackRight,new Orientation(new Vector2(1f,1f))},
                    {skinBack,new Orientation(new Vector2(0.5f,1f))},
                    {cornerBackLeft,new Orientation(new Vector2(0,1f))},
                    {skinSideLeft,new Orientation(new Vector2(0,0.5f),90)},
                }));

            Decisions.Add(designDecision);

            //Skin part
            var frameModuleLowest = new Thing("FrameModule", new List<string>(){"Box","Outside"});
            var frameModuleLow = new Thing("FrameModule", new List<string>() { "Window" });
            var frameModuleHigh = (Thing)frameModuleLowest.Clone();
            var frameModuleHighest = (Thing)frameModuleLow.Clone();

            var skinFrontPattern = new Pattern( new List<Thing>()
            {
                frameModuleLowest,frameModuleLow,frameModuleHigh,frameModuleHighest,
            }, new List<Relation>()
            {
                new(frameModuleLowest,frameModuleLow),
                new(frameModuleLow,frameModuleHigh),
                new(frameModuleHigh,frameModuleHighest),
            }, new Dictionary<Thing, Orientation>()
            {
                {frameModuleLowest,new Orientation(0)}, {frameModuleLow,new Orientation(1.0f/3.0f)}, 
                {frameModuleHigh,new Orientation(2.0f/3.0f)},{frameModuleHighest,new Orientation(1)}
            });

            var skinDecision = new Decision("Skin", skinFrontPattern, new Orientation(0,gamma:90));

            Decisions.Add(skinDecision);

        }

        [TestMethod]
        public void TestGraphCompiler()
        {
            var decisionCompiler = new DecisionCompiler(new GrGenGraphTransformationBackend());
            var results = decisionCompiler.Compile(Decisions);
        }
    }
}
