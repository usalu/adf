using System;
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.ObjectModel.Decisions.Patterns;

public class Pattern : SemanticSkeleton
{
    public Pattern(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null, Dictionary<Thing, Orientation>? embedding = null) : base(things, relations, embedding)
    {
    }
    public Pattern(Thing thing, IEnumerable<Relation>? relations = null, Dictionary<Thing, Orientation>? embedding = null) :
        base(new List<Thing>() { thing }, relations, embedding)
    {
    }
}