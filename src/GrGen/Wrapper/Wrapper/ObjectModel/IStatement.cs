using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrGenWrapper.ObjectModel
{
    public interface IStatement
    {
        void Write(StringBuilder builder);
    }
}
