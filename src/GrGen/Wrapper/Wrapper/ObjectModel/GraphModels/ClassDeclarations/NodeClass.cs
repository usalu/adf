using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations
{
    public class NodeClass : ClassDeclaration
    {
        public NodeClass(string name, IEnumerable<ClassDeclaration>? parentClassDeclarations = null) : base(name, parentClassDeclarations)
        {
        }

        public override void Write(StringBuilder builder)
        {
            builder.Append("node class " + Name);
            if (ParentClassDeclarations.Any())
                builder.Append(" extends " + string.Join(",", ParentClassDeclarations.Select(x => x.Name)));
            builder.AppendLine(";");
        }
    }
}
