using System;

namespace Entidades
{
    public static class ExtensionLong
    {
        public static double CantidadDeDigitos(this double number)
        {
            double retorno;
            string strNumber;
            strNumber = number.ToString();
            retorno = strNumber.Length;

            return retorno;
        }
    }
}
