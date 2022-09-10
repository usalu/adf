using System;
using System.Collections.Generic;
using GrGenWrapper.ObjectModel.GraphModels.ClassDeclarations;

namespace GrGenWrapper.ObjectModel.GraphModels
{

    public class GraphModel:GrGenFile
    {
        /// <summary>
        /// Declaration of imported graph models.
        /// </summary>
        public List<GraphModel> ModelUsage { get; set; }

        public List<EnumDeclaration> EnumDeclarations { get; set; }
        public List<ClassDeclaration> ClassDeclarations { get; set; }


        public GraphModel(string name, List<Snippet> snippets = null, List<GraphModel> modelUsage = null,
            List<EnumDeclaration> enumDeclarations = null, List<ClassDeclaration> classDeclarations = null) : base(name,
            snippets)
        {
            ModelUsage = modelUsage ?? new List<GraphModel>();
            EnumDeclarations = enumDeclarations ?? new List<EnumDeclaration>();
            ClassDeclarations = classDeclarations ?? new List<ClassDeclaration>();
        }
        public override string FullName => Name + ".gm";
    }
}
