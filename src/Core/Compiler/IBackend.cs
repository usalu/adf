using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel;

namespace DDF.Core.Compiler
{
    public interface IBackend
    {
        string GetIfc(Design design);
    }
}
