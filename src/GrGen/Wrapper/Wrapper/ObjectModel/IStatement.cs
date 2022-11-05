using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrGenWrapper.ObjectModel
{
    /// <summary>
    /// Any statement that is a new block of code.
    /// </summary>
    public interface IStatement
    {
        void Write(StringBuilder builder);
    }
}
