using Backtracking.Problemas;
using Backtracking.Problemas.Granjero;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Backtracking
{
    class Backtracking
    {
        static Granjeros granjero = new Granjeros();

        static void Main(string[] args)
        {
            List<EstadoGranjero> solucion = new List<EstadoGranjero>();


            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Resolver_pmax(7, ref solucion);

            stopwatch.Stop();

            Console.WriteLine("Elapsed={0}", stopwatch.Elapsed);

            foreach (EstadoGranjero estado in solucion)
            {
                Console.WriteLine(estado.ToString());
            }
        }

        public static bool Resolver_pmax(int pMax, ref List<EstadoGranjero> solucion)
        {
            List<EstadoGranjero> visitados = new List<EstadoGranjero>();
            if(Resolver_pmax(pMax, granjero.getEstadoInicial(), ref visitados, ref solucion) == true)
            {
                solucion.Add(granjero.getEstadoInicial());
                solucion.Reverse();
                return true;
            }
            return false;
        }

        public static bool Resolver_pmax(int PRestante, EstadoGranjero EActual, ref List<EstadoGranjero> Visitados, ref List<EstadoGranjero> Solucion)
        {
            if (EActual.Equals(granjero.getEstadoFinal()))
            {
                return true;
            }

            if (PRestante <= 0)
            {
                return false;
            }

            PRestante -= 1;

            for(int i = 0; i < granjero.getNumeroMovimientos(); i++)
            {
                EstadoGranjero siguiente = granjero.mover(EActual, i);

                if(siguiente.isValid() == true && Visitados.Contains(siguiente) == false)
                {
                    Visitados.Add(siguiente);
                    if(Resolver_pmax(PRestante, siguiente, ref Visitados, ref Solucion) == true)
                    {
                        Solucion.Add(siguiente);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
