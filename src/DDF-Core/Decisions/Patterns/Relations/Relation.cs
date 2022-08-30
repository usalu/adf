using DDF.Core.Things;

namespace DDF.Core.Relations;

public abstract class Relation: Instance
{

    public Thing Relating { get; }
    public Thing Related { get; }

   

}