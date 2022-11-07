using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

namespace GrGenWrapper.Wrappers.Graphs
{
    public class Edge
    {
        public Node Relating { get; }
        public Node Related { get; }

        public Edge(Node relating, Node related)
        {
            Relating = relating;
            Related = related;
        }
    }
}
