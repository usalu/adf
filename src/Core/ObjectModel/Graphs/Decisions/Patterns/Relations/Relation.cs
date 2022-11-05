using System;
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Relations;

public class Relation: Instance
{

    public Thing Relating { get; }
    public Thing Related { get; }

    public Relation(Thing relating, Thing related, IEnumerable<string>? concepts = null,
        CloneableDictionary<string,ICloneable>? parameters = null) : base(concepts, parameters)
    {
        Relating = relating ?? throw new ArgumentNullException(nameof(relating));
        Related = related ?? throw new ArgumentNullException(nameof(related));
    }
    /// <summary>
    /// Returns a shallow clone. The relation things will be the same.
    /// If you consider adding two new nodes, add them to the pattern.
    /// </summary>
    /// <returns></returns>
    public override object Clone() => new Relation(Relating, Related, Concepts, Parameters);
}