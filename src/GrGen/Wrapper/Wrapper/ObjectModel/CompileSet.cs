using System;
using System.Collections.Generic;
using System.Linq;
using GrGenWrapper.ObjectModel.GraphModels;
using GrGenWrapper.ObjectModel.RuleSets;

namespace GrGenWrapper.ObjectModel
{
    public class CompileSet
    {
        public IEnumerable<GraphModel> Models { get;}
        public RuleSet RuleSet { get;}
        public string Name => RuleSet.Name;
        public string FullName => RuleSet.FullName;
        public CompileSet(IEnumerable<GraphModel> models, RuleSet ruleSet)
        {
            Models = models ?? throw new ArgumentNullException(nameof(models));
            RuleSet = ruleSet ?? throw new ArgumentNullException(nameof(ruleSet));
        }

        public void Write(string folder)
        {
            foreach (var model in Models) model.Write(folder);
            RuleSet.Write(folder);
        }
    }
}
