using System;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string retorno = string.Empty;

            if (numero >= 0)
            {
                int resultado = (int) numero;
                int aux;
                do
                {
                    aux = resultado % 2;
                    resultado /= 2;
                    retorno = aux.ToString() + retorno;
                } while (resultado > 0);
            }

            return retorno;
        }

        public static double BinarioDecimal(string numero)
        {
            double retorno = 0;
            double cantidadDeCaracteres = numero.Length;

            foreach (char caracter in numero)
            {
                cantidadDeCaracteres--;
                if(caracter == '1')
                {
                    retorno += (int)Math.Pow(2, cantidadDeCaracteres);
                }
            }

            return retorno;
        }
    }
}
