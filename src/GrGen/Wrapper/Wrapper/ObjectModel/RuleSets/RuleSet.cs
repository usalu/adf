using System;
using System.Collections.Generic;
using GrGenWrapper.ObjectModel.RuleSets.Actions;

namespace GrGenWrapper.ObjectModel.RuleSets
{
    public class RuleSet:GrGenFile
    {
        
        public override string FullName => Name + ".grg";
        public FileHeader FileHeader { get; set; }

        #region Actions
        public List<Rule> Rules { get; set; }
        public List<Test> Tests { get; set; }
        #endregion

        public RuleSet(string name, FileHeader fileHeader = null,
            List<Rule> rules = null, List<Test> tests = null, List<Snippet> snippets = null) : base(name, snippets)
        {
            FileHeader = fileHeader ?? new FileHeader();
            Rules = rules ?? new List<Rule>();
            Tests = tests ?? new List<Test>();
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
