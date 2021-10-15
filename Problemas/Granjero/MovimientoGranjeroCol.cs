﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas.Granjero
{
    public class MovimientoGranjeroCol : Movimiento
    {
        public override EstadoGranjero mover(EstadoGranjero estado)
        {
            EstadoGranjero estadoSig = (EstadoGranjero)estado.Clone();

            estadoSig.moverGranjero();
            estadoSig.moverCol();

            return estadoSig;
        }
    }
}
