#nullable enable
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns;

namespace DDF.Core.ObjectModel.Decisions;

public class Decision
{
    public Pattern Context { get; }
    public Pattern Modification { get; }
    public DecisionMechanism DecisionMechanism { get; }
    public IEnumerable<Decision> RequiredDecisions { get; }
    public Decision(Pattern context, Pattern modification, DecisionMechanism decisionMechanism = default, IEnumerable<Decision>? requiredDecisions = null)
    {
        Context = context;
        Modification = modification;
        DecisionMechanism = decisionMechanism;
        RequiredDecisions = requiredDecisions ?? new List<Decision>();
    }

}
