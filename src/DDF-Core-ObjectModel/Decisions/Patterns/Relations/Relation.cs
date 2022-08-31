using DDF.Core.Things;

namespace DDF.Core.Relations;

public class Relation: Instance
{

    public Thing Relating { get; }
    public Thing Related { get; }

    public Relation(Thing relating, Thing related, string name = "", IEnumerable<string>? concepts = null,
        Dictionary<string, object>? parameters = null) : base(name, concepts, parameters)
    {
        Relating = relating ?? throw new ArgumentNullException(nameof(relating));
        Related = related ?? throw new ArgumentNullException(nameof(related));
    }
}