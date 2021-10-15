using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking.Problemas.Granjero
{
    public class EstadoGranjero : ICloneable
    {
        private int[] estado;

        public EstadoGranjero(int[] estado)
        {
            this.estado = new int[estado.Length];

            for (int i = 0; i < estado.Length; i++)
            {
                this.estado[i] = estado[i];
            }
        }

        public int getGranjero()
        {
            return estado[0];
        }

        public void moverGranjero()
        {
            estado[0] = (estado[0] + 1) % 2;
        }

        public int getOveja()
        {
            return estado[1];
        }

        public void moverOveja()
        {
            estado[1] = (estado[1] + 1) % 2;
        }

        public int getCol()
        {
            return estado[2];
        }

        public void moverCol()
        {
            estado[2] = (estado[2] + 1) % 2;
        }

        public int getLobo()
        {
            return estado[3];
        }

        public void moverLobo()
        {
            estado[3] = (estado[3] + 1) % 2;
        }

        public object Clone()
        {
            EstadoGranjero cloned = new EstadoGranjero(estado);
            return cloned;
        }

        public bool isValid()
        {
            if (estado[0] == estado[1] || estado[0] != estado[1] && estado[0] == estado[2] && estado[2] == estado[3])
            {
                return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if (obj == null || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                EstadoGranjero e = (EstadoGranjero)obj;

                for (int i = 0; i < e.estado.Length; i++)
                {
                    if (e.estado[i] != estado[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public override string ToString()
        {
            string output = "";

            output += "[";

            foreach (int ei in estado)
            {
                output += ei + ", ";
            }

            output += "]";

            return output;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
