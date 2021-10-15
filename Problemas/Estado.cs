using Backtracking.Problemas.Granjero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas
{
    public abstract class Estado : ICloneable
    {
        public abstract object Clone();
    }
}
