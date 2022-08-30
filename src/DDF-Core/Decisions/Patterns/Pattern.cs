using DDF.Core.Designs;
using DDF.Core.Relations;
using DDF.Core.Things;

namespace DDF.Core.Designs.Patterns;

public abstract class Pattern
{
    protected Pattern(IEnumerable<Thing> things, IEnumerable<Relation> relations, Dictionary<Thing, string[]> concepts)
    {
        Things = things ?? throw new ArgumentNullException(nameof(things));
        Relations = relations ?? throw new ArgumentNullException(nameof(relations));
        Concepts = concepts ?? throw new ArgumentNullException(nameof(concepts));
    }

    public IEnumerable<Thing> Things { get;}
    public IEnumerable<Relation> Relations { get;}
    public Dictionary<Thing, string[]> Concepts { get; }
}