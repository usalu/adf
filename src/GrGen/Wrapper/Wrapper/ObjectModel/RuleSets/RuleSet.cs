using System.Collections.Generic;
using GrGenWrapper.ObjectModel.RuleSets.Actions;

namespace GrGenWrapper.ObjectModel.RuleSets
{
    public class RuleSet:File
    {
        
        public string Name { get; set; }
        public string FullName => Name + ".grg";
        public FileHeader FileHeader { get; set; }

        #region Actions
        public List<Rule> Rules { get; set; }
        public List<Test> Tests { get; set; }
        #endregion

        public RuleSet(string name, List<Snippet> snippets = null) : base(name, snippets)
        {
        }

        internal override void Prepare()
        {
            Statements.Add(FileHeader);
            Statements.AddRange(Rules);
            Statements.AddRange(Tests);
            base.Prepare();
        }
    }
}
