using System.Collections.Generic;
using System.Text;

namespace GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations
{
    public abstract class ClassDeclaration: IStatement
    {
        protected ClassDeclaration(string name, IEnumerable<ClassDeclaration>? parentClassDeclarations = null)
        {
            Name = name;
            ParentClassDeclarations = parentClassDeclarations ?? new List<ClassDeclaration>();
        }

        public string Name { get; set; }

        public IEnumerable<ClassDeclaration> ParentClassDeclarations { get; set; }
        public abstract void Write(StringBuilder builder);

    }
}
