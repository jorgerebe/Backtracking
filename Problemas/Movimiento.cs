using Backtracking.Problemas.Granjero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas
{
    public abstract class Movimiento
    {
        public abstract EstadoGranjero mover(EstadoGranjero estado);
    }
}
