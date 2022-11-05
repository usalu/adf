﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Numerics;
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
        public List<Decision> decisions = new List<Decision>();
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
                new Pattern2D(new List<Thing>()
                {
                    cornerFrontLeft, cornerFrontRight, cornerBackLeft,cornerBackRight, 
                    skinFrontLeft, skinFrontRight, skinSideLeft, skinSideRight, skinBack
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
                    new(cornerBackLeft, skinFrontLeft)
                }, new Dictionary<Thing, Orientation2D>()
                {
                    {cornerFrontLeft, new Orientation2D()},
                    {skinFrontLeft,new Orientation2D(new Vector2(0.25f,0))},
                    {entrance,new Orientation2D(new Vector2(0.5f,0))},
                    {skinFrontRight,new Orientation2D(new Vector2(0.75f,0))},
                    {cornerFrontRight,new Orientation2D(new Vector2(1f,0))},
                    {skinSideRight,new Orientation2D(new Vector2(1f,0.5f))},
                    {cornerBackRight,new Orientation2D(new Vector2(1f,1f))},
                    {skinBack,new Orientation2D(new Vector2(0.5f,1f))},
                    {cornerBackLeft,new Orientation2D(new Vector2(0,1f))},
                    {skinSideLeft,new Orientation2D(new Vector2(0,0.5f))},
                }));

            decisions.Add(designDecision);

            //Skin part
            var frameModuleLowest = new Thing("FrameModule", new List<string>(){"Box","Outside"});
            var frameModuleLow = new Thing("FrameModule", new List<string>() { "Window" });
            var frameModuleHigh = (Thing)frameModuleLowest.Clone();
            var frameModuleHighest = (Thing)frameModuleLow.Clone();

            var skinFrontPattern = new Pattern1D( new List<Thing>()
            {
                frameModuleLowest,frameModuleLow,frameModuleHigh,frameModuleHighest,
            }, new List<Relation>()
            {
                new(frameModuleLowest,frameModuleLow),
                new(frameModuleLow,frameModuleHigh),
                new(frameModuleHigh,frameModuleHighest),
            }, new Dictionary<Thing, double>()
            {
                {frameModuleLowest,0}, {frameModuleLow,1.0/3.0}, {frameModuleHigh,2.0/3.0},{frameModuleHighest,1}
            });

            var skinDecision = new Decision("Skin", skinFrontPattern);

            decisions.Add(skinDecision);

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}