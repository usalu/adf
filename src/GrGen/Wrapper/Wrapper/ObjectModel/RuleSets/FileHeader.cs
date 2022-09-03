using System.Collections.Generic;
using System.Text;
using GrGenWrapper.ObjectModel.GraphModels;

namespace GrGenWrapper.ObjectModel.RuleSets
{
    public  class FileHeader: IStatement
    {
        public List<GraphModel> ModelUsage { get; set; }
        public List<RuleSet> RulesInclusion { get; set; }
        //public IEnumerable<GlobalVariableDeclaration> GlobalGlobalVariableDeclarations { get; set; }
        public void Write(StringBuilder builder)
        {
            ModelUsage.ForEach(x => builder.AppendLine("#using \"" + x.Name + ".gm\"\n"));
            RulesInclusion.ForEach(x => builder.AppendLine("#include \"" + x.Name + ".grg\"\n"));
        }
    }
}
