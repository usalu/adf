using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDF.Core.ObjectModel.Decisions.Patterns.Spaces;

namespace DDF.Core.Compiler.Backends
{
    public interface IGeometryBackend
    {
        public Space3D DefaultSpace3D { get; }
        public Surface DefaultSurface { get; }
        public Curve DefaultCurve { get; }
    }
}
