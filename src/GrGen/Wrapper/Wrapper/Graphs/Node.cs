using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

namespace GrGenWrapper.Wrappers.Graphs
{
    public class Node
    {
        public string TypeName;
        public Guid Guid { get; }
        public Dictionary<string, object> Attributes;

        public Node(string typeName, Dictionary<string, object> attributes)
        {
            TypeName = typeName;
            Attributes = attributes;
            Guid= Guid.NewGuid();
        }
    }
}
