#nullable enable
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DDF.Core.ObjectModel.Decisions.Patterns;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions;

public class Decision
{
    public Pattern Context { get; }
    public Pattern Modification { get; }
    public DecisionMechanism DecisionMechanism { get; }
    public IEnumerable<Decision> RequiredDecisions { get; }
    public Decision(Pattern context, Pattern modification, 
        DecisionMechanism decisionMechanism = default,
        IEnumerable<Decision>? requiredDecisions = null)
    {
        Context = context;
        Modification = modification;
        DecisionMechanism = decisionMechanism;
        RequiredDecisions = requiredDecisions ?? new List<Decision>();
    }

    public Decision(string typeName, Pattern modification, DecisionMechanism decisionMechanism = default,
        IEnumerable<Decision>? requiredDecisions = null)
        : this(new Pattern1D(new Thing(typeName)), modification, decisionMechanism, requiredDecisions)
    {
    }

}
