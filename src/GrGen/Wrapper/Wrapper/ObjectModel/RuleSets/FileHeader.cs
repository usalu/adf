using System.Collections.Generic;
using System.Text;
using GrGenWrapper.ObjectModel.GraphModels;

namespace GrGenWrapper.ObjectModel.RuleSets
{
    public  class FileHeader: IStatement
    {
        /// <summary>
        /// Declaration of imported graph models.
        /// </summary>
        public List<GraphModel> ModelUsage { get; set; }
        public List<RuleSet> RulesInclusion { get; set; }
        //public IEnumerable<GlobalVariableDeclaration> GlobalGlobalVariableDeclarations { get; set; }

        public FileHeader(List<GraphModel> modelUsage = null, List<RuleSet> rulesInclusion = null)
        {
            ModelUsage = modelUsage ?? new List<GraphModel>();
            RulesInclusion = rulesInclusion ?? new List<RuleSet>();
        }

        public void Write(StringBuilder builder)
        {
            ModelUsage.ForEach(x => builder.AppendLine("#using \"" + x.Name + ".gm\"\n"));
            RulesInclusion.ForEach(x => builder.AppendLine("#include \"" + x.Name + ".grg\"\n"));
        }
    }
}
