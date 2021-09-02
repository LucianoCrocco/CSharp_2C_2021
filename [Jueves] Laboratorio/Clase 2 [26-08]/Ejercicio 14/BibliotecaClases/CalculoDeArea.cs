using System;

namespace BibliotecaClases
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double x)
        {
            double retorno;

            retorno = x * x;

            return retorno;
        }

        public static double CalcularTriangulo(double x, double y)
        {
            double retorno;

            retorno = x * y;

            return retorno;
        }

        public static double CalcularCirculo(double x)
        {
            double retorno;

            x = Math.Pow(x, 2);

            retorno = Math.PI * x;

            return retorno;
        }
    }
}
