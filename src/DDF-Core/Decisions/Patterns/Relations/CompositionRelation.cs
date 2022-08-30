using DDF.Core.Things;

namespace DDF.Core.Relations;

public class CompositionRelation : Relation
{
    public CompositionRelation(IEnumerable<Thing> relating, IEnumerable<Thing> related, string name = "", IEnumerable<string>? concepts = null, Dictionary<string, object>? parameters = null) : base(relating, related, name, concepts, parameters)
    {
    }
}