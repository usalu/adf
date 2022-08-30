using DDF.Core.Designs;
using DDF.Core.Designs.Patterns;

namespace DDF.Core.Decisions;

public class Decision
{
    public Decision(Pattern context, Pattern modification, IEnumerable<Decision> requiredDecisions)
    {
        Context = context;
        Modification = modification;
        RequiredDecisions = requiredDecisions;
    }
    public Pattern Context { get; }
    public Pattern Modification { get; }
    public IEnumerable<Decision> RequiredDecisions { get; }

}