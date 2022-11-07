using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;
using GrGenWrapper.Wrappers.Graphs;

namespace DDF.Core.Compiler.GGXBBackend
{
    internal class GraphTranslator
    {
        internal SemanticSkeleton Translate(GrGenWrapper.Wrappers.Graphs.Graph graph)
        {
            var things = new List<Thing>();
            var relations = new List<Relation>();
            var embedding = new Dictionary<Thing, Orientation>();
            var thingMap = new Dictionary<Node, Thing>();
            foreach (var node in graph.Nodes)
            { 
                var thing = new Thing(node.TypeName, parameters: new CloneableDictionary<string, ICloneable>(node.Attributes));
                things.Add(thing);
                thingMap.Add(node, thing);
                var orientation = node.Attributes["o"];
                var point = orientation.GetType().GetProperty("p").GetValue(orientation);
                embedding.Add(thing, new Orientation(new Vector3(
                        Convert.ToSingle(point.GetType().GetProperty("x").GetValue(point)),
                        Convert.ToSingle(point.GetType().GetProperty("y").GetValue(point)),
                        Convert.ToSingle(point.GetType().GetProperty("z").GetValue(point))),
                    (double)orientation.GetType().GetProperty("alpha").GetValue(orientation),
                    (double)orientation.GetType().GetProperty("gamma").GetValue(orientation)));
            }
            relations.AddRange(graph.Edges.Select(x=>new Relation(thingMap[x.Related], thingMap[x.Relating])));
            

            return new SemanticSkeleton(things,relations, embedding);
        }

        //internal GrGenWrapper.Wrappers.Graphs.Graph Translate(SemanticSkeleton skeleton)
        //{
        //    return new GrGenWrapper.Wrappers.Graphs.Graph();
        //}
    }
}
