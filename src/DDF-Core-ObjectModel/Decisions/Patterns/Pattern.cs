using DDF.Core.Designs;
using DDF.Core.Relations;
using DDF.Core.Things;

namespace DDF.Core.Designs.Patterns;

public abstract class Pattern
{
    public IEnumerable<Thing> Things { get;}
    public IEnumerable<Relation>? Relations { get;}

    protected Pattern(IEnumerable<Thing> things, IEnumerable<Relation>? relations = null)
    {
        Things = things ?? throw new ArgumentNullException(nameof(things));
        Relations = relations;
    }
}