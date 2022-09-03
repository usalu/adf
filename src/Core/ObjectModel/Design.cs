﻿using System;
using System.Collections.Generic;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.ObjectModel
{
    public class Design
    {

        public string Id { get; }
        public IEnumerable<Decision> Decisions { get; }

        public Design(string id, IEnumerable<Decision> decisions)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Decisions = decisions ?? throw new ArgumentNullException(nameof(decisions));
        }
    }

    //public class ProjectDirector
    //{
    //    private DecisionBuilder decisionBuilder;
    //}

    //public interface DecisionBuilder
    //{
    //    Decision BuildDecision();
    //}
}