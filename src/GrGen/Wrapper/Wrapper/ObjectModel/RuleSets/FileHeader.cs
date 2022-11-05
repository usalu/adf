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
        public IEnumerable<GraphModel> ModelUsage { get; set; }
        public IEnumerable<RuleSet> RulesInclusion { get; set; }
        //public IEnumerable<GlobalVariableDeclaration> GlobalGlobalVariableDeclarations { get; set; }

        public FileHeader(IEnumerable<GraphModel> modelUsage = null, IEnumerable<RuleSet> rulesInclusion = null)
        {
            ModelUsage = modelUsage ?? new List<GraphModel>();
            RulesInclusion = rulesInclusion ?? new List<RuleSet>();
        }

        public void Write(StringBuilder builder)
        {
            foreach (var model in ModelUsage) builder.AppendLine("#using \"" + model.Name + ".gm\"\n");
            foreach (var ruleSet in RulesInclusion) builder.AppendLine("#include \"" + ruleSet.Name + ".grg\"\n");
        }
    }
}
