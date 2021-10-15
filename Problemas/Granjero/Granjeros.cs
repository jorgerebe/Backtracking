using Backtracking.Problemas.Granjero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas
{
    public class Granjeros
    {
        private static EstadoGranjero estadoInicial = new EstadoGranjero(new int[] { 0, 0, 0, 0 });
        private static EstadoGranjero estadoFinal = new EstadoGranjero(new int[] { 1, 1, 1, 1 });

        private Movimiento[] movimientos = { new MovimientoGranjero(), new MovimientoGranjeroOveja(), new MovimientoGranjeroCol(), new MovimientoGranjeroLobo() };

        public Granjeros()
        {

        }

        public int getNumeroMovimientos()
        {
            return movimientos.Length;
        }

        public EstadoGranjero mover(EstadoGranjero estado, int id)
        {
            return movimientos[id].mover(estado);
        }

        public EstadoGranjero getEstadoInicial()
        {
            return estadoInicial;
        }

        public EstadoGranjero getEstadoFinal()
        {
            return estadoFinal;
        }
    }
}
