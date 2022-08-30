using DDF.Core.Things;

namespace DDF.Core.Relations;

public abstract class Relation
{

    public IEnumerable<Thing> Relating { get; }
    public IEnumerable<Thing> Related { get; }
    public Directedness Directedness { get; }

}