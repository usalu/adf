using DDF.Core.Decisions.Patterns.Relations;
using DDF.Core.Ports;
using DDF.Core.Things;

namespace DDF.Core.Relations;

public class AssemblyRelation : BidirectionalRelation
{
    public Port RelatingPort;
    public Port RelatedPort;

    public AssemblyRelation(IEnumerable<Thing> relating, IEnumerable<Thing> related, Port relatingPort, Port relatedPort, string name = "", IEnumerable<string>? concepts = null,
        Dictionary<string, object>? parameters = null) : base(relating, related, name, concepts, parameters)
    {
        RelatingPort = relatingPort ?? throw new ArgumentNullException(nameof(relatingPort));
        RelatedPort = relatedPort ?? throw new ArgumentNullException(nameof(relatedPort));
    }
}