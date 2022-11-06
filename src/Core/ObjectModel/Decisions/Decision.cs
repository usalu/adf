#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using DDF.Core.ObjectModel.Decisions.Patterns;
using DDF.Core.ObjectModel.Decisions.Patterns.Things;
using DDF.Core.ObjectModel.Graphs.Decisions.Patterns.Orientations;

namespace DDF.Core.ObjectModel.Decisions;

public class Decision
{
    public Pattern Context { get; }
    public Pattern ModifiedContext { get; }
    public Orientation3D ModifiedContextOrientation { get; }
    public DecisionMechanism DecisionMechanism { get; }

    /// <summary>
    /// Returns true if the decision creates at least one new type of things.
    /// </summary>
    /// <returns></returns>
    public bool IsTypeCreational() {
        HashSet<string> contextualThingTypeNameSet = new HashSet<string>();
        foreach (var contextualThingTypeName in Context.Things.Select(x => (x.TypeName))) contextualThingTypeNameSet.Add(contextualThingTypeName);
        foreach (var modificationThingTypeName in ModifiedContext.Things.Select(x => (x.TypeName)))
            if (!contextualThingTypeNameSet.Contains(modificationThingTypeName)) return true;

        return false;
    }
    /// <summary>
    /// Returns true if the the context is entirely destroyed after the rewriting process.
    /// </summary>
    /// <returns></returns>
    public bool IsTransient()
    {
        //if (DecisionMechanism== DecisionMechanism.Destruction)
        //   pass
        throw new NotImplementedException();
    }

    public Decision(Pattern context, Pattern modifiedContext, Orientation3D modifiedContextOrientation = default, DecisionMechanism decisionMechanism = default)
    {
        Context = context;
        ModifiedContext = modifiedContext;
        ModifiedContextOrientation = modifiedContextOrientation;
        DecisionMechanism = decisionMechanism;
    }

    public Decision(string typeName, Pattern modifiedContext, Orientation3D modifiedContextOrientation = default, DecisionMechanism decisionMechanism = default )
        : this(new Pattern1D(new Thing(typeName)), modifiedContext, modifiedContextOrientation, decisionMechanism)
    {
    }

}
