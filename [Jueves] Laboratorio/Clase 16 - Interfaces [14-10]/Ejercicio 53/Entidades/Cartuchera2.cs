using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2<T, U>
        where T : Boligrafo
        where U : Lapiz
    {
        private List<T> boligrafo;
        private List<U> lapiz;

        public Cartuchera2()
        {
            this.boligrafo = new List<T>();
            this.lapiz = new List<U>();
        }

        public bool ProbarElementos()
        {
            bool retornoLapiz = true;
            bool retornoBoligrafo = true;
            foreach (Boligrafo boli in this.boligrafo)
            {
                boli.UnidadesDeEscritura = -1;
                if (boli.UnidadesDeEscritura == 0)
                {
                    boli.Recargar(20);
                    retornoBoligrafo = false;
                }
            }

            foreach (Lapiz lapiz in this.lapiz)
            {
                ((IAcciones)lapiz).UnidadesDeEscritura = -1;
                if (((IAcciones)lapiz).UnidadesDeEscritura == 0)
                {
                    ((IAcciones)lapiz).Recargar(20);
                    retornoLapiz = false;
                }
            }

            return retornoBoligrafo && retornoLapiz;
        }

        public static Cartuchera2<T, U> operator +(Cartuchera2 <T, U> cartuchera, Boligrafo boligrafo)
        {
            cartuchera.boligrafo.Add((T)boligrafo);

            return cartuchera;
        }

        Lapiz lapiz3 = new Lapiz(0);

        public static Cartuchera2<T, U> operator +(Cartuchera2<T, U> cartuchera, Lapiz lapiz)
        {
            cartuchera.lapiz.Add((U)lapiz);

            return cartuchera;
        }
    }
}
