﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDF.Core.ObjectModel.Decisions.Patterns.Spaces
{

    public class Surface: Space
    {
        public static Surface WorldXY => new Surface();
    }
}