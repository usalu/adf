using System;
using System.Collections.Generic;
using System.Linq;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;

namespace GrGenWrapper.Wrappers.RewriteSequences
{
    /// <summary>
    /// Match every rule as many times as possible and sequentially repeat for every rule.
    /// </summary>
    public class LazyGreedyAndListRewriteSequence: RewriteSequence
    {
        public IEnumerable<string> RuleNames { get; set; }

        public LazyGreedyAndListRewriteSequence(IEnumerable<string> ruleNames)
        {
            RuleNames = ruleNames ?? throw new ArgumentNullException(nameof(ruleNames));
        }

        public override void ApplyOn(IGraphProcessingEnvironment graphProcessingEnvironment)
        {
            graphProcessingEnvironment.ApplyGraphRewriteSequence(string.Join("&&", RuleNames.Select(x=>x+"*")));
        }
    }
}
