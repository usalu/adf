using System;
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.ObjectModel
{
    public class DecisionSequence
    {
        public IEnumerable<Decision> Decisions { get; }

        public DecisionSequence(IEnumerable<Decision> decisions)
        {
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