using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using de.unika.ipd.grGen.libGr;

namespace GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations
{
    public class EdgeClass: ClassDeclaration
    {
        public EdgeClass(string name, IEnumerable<ClassDeclaration>? parentClassDeclarations = null) : base(name, parentClassDeclarations)
        {
        }

        public override void Write(StringBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
}
