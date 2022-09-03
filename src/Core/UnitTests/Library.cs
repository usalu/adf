using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel.Decisions;

namespace DDF.Core.UnitTests
{
    [TestClass]
    public class Library
    {
        public Dictionary<string,Decision> Decisions { get; set; }

        [TestInitialize]
        public void LibraryInitialize()
        {

        }

    }
}
