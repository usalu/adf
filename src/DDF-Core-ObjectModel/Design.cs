using System.Dynamic;
using DDF.Core.Decisions;
using DDF.Core.Things;
using Microsoft.VisualBasic;

namespace DDF.Core
{
    public class Design
    {

        public string Id { get; }
        public IEnumerable<Decision> Decisions { get; }

        public Design(string id, IEnumerable<Decision> decisions)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Decisions = decisions ?? throw new ArgumentNullException(nameof(decisions));
        }
    }

    //public class ProjectDirector
    //{
    //    private DecisionBuilder decisionBuilder;
    //}

    //public interface DecisionBuilder
    //{
    //    Decision BuildDecision();
    //}
}