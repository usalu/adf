﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Spaces
{
    

    public class Curve: Space
    {
        public static Curve NormalizedXLine => new Curve();
    }
}