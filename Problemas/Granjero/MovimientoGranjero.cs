using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas.Granjero
{
    public class MovimientoGranjero : Movimiento
    {
        public override EstadoGranjero mover(EstadoGranjero estado)
        {
            EstadoGranjero estadoSig = (EstadoGranjero)estado.Clone();

            estadoSig.moverGranjero();

            return estadoSig;
        }
    }
}
