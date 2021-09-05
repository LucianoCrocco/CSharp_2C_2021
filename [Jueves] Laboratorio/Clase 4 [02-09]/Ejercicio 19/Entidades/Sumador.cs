using System;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadDeSumas;

        public Sumador() :
            this(0)
        { }
        public Sumador(int inicializacion)
        {
            this.cantidadDeSumas = inicializacion;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadDeSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadDeSumas++;
            return String.Concat(a, b);
        }

        public static explicit operator int (Sumador x) {
            return x.cantidadDeSumas;
        }

        public static long operator +()


    }
}
