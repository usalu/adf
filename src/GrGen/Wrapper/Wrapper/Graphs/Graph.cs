using System;
using System.Collections.Generic;
using System.Linq;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

namespace GrGenWrapper.Wrappers.Graphs
{
    public class Graph
    {
        public IEnumerable<Node> Nodes { get; }
        public IEnumerable<Edge> Edges { get; }

        internal Graph(IGraph graph)
        {
            var nodes = new List<Node>();
            var edges = new List<Edge>();
            
            var nodeMap = new Dictionary<INode, Node>();
            foreach (var node in graph.Nodes)
            {
                var attributes = new Dictionary<string, object>();
                var attributeTypeNames = node.Type.AttributeTypes.Select(x => x.Name);
                foreach (var attributeType in attributeTypeNames)
                    if (attributeType != null) attributes.Add(attributeType,node.GetAttribute(attributeType));
                var simplifiedNode = new Node(node.Type.Name, attributes);
                nodes.Add(simplifiedNode);
                nodeMap.Add(node, simplifiedNode);
            }
            Nodes=nodes;

            foreach (var edge in graph.Edges)
            {
                var simplifiedEdge = new Edge(nodeMap[edge.Source],nodeMap[edge.Target]);
                edges.Add(simplifiedEdge);
                
            }
            Edges=edges;
        }
       
    }
}
