using System.Collections.Generic;
using System.Text;

namespace GrGenWrapper.ObjectModel.RuleSets.Actions
{
    public class Rule: IStatement
    {
        public List<Graphlet> Graphlets { get; set; }
        public void Write(StringBuilder builder)
        {
            Graphlets.ForEach(x => x.Write(builder));
        }
    }
}
