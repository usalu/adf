using System.Collections.Generic;
using System.Text;

namespace GrGenWrapper.ObjectModel.RuleSets.Actions
{
    public class Rule: IStatement
    {
        public IEnumerable<Graphlet> Graphlets { get; set; }

        public Rule(IEnumerable<Graphlet> graphlets)
        {
            Graphlets = graphlets;
        }

        public void Write(StringBuilder builder)
        {
            foreach (var graphlet in Graphlets) graphlet.Write(builder);
        }
    }
}
