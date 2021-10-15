using Backtracking.Problemas.Granjero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas
{
    public class MovimientoGranjeroOveja : Movimiento
    {
        public override EstadoGranjero mover(EstadoGranjero estado)
        {
            EstadoGranjero estadoSig = (EstadoGranjero)estado.Clone();

            estadoSig.moverGranjero();
            estadoSig.moverOveja();

            return estadoSig;
        }
    }
}
