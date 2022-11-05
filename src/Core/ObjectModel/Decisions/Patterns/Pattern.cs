using System;
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions.Patterns.Relations;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;

namespace DDF.Core.ObjectModel.Decisions.Patterns;

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