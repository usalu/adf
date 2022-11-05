using System;
using System.Collections.Generic;
using System.Text;
using GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations;

namespace GrGenWrapper.ObjectModel.GraphModels
{

    public class GraphModel:GrGenFile, IStatement
    {
        /// <summary>
        /// Declaration of imported graph models.
        /// </summary>
        public IEnumerable<GraphModel> ModelUsage { get; set; }

        public IEnumerable<EnumDeclaration> EnumDeclarations { get; set; }
        public IEnumerable<ClassDeclaration> ClassDeclarations { get; set; }


        public GraphModel(string name, IEnumerable<Snippet> snippets = null, IEnumerable<GraphModel> modelUsage = null,
            IEnumerable<EnumDeclaration> enumDeclarations = null, IEnumerable<ClassDeclaration> classDeclarations = null) : base(name,
            snippets)
        {
            ModelUsage = modelUsage ?? new List<GraphModel>();
            EnumDeclarations = enumDeclarations ?? new List<EnumDeclaration>();
            ClassDeclarations = classDeclarations ?? new List<ClassDeclaration>();
        }
        public override string FullName => Name + ".gm";

        internal override void Prepare()
        {
            Statements.AddRange(ModelUsage);
            Statements.AddRange(EnumDeclarations);
            Statements.AddRange(ClassDeclarations);
            base.Prepare();
        }

        /// <summary>
        /// When GraphModel is called as a Statement it will append the using statement.
        /// </summary>
        /// <param name="builder"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Write(StringBuilder builder)
        {
            builder.AppendLine("#using " + "\"" + FullName + "\"");
        }
    }
}
