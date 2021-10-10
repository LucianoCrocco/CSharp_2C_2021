using System;

namespace Entidades
{
    public static class ExtensionString
    {
        public static double ContadorDeSignosDePuntuacion(this string palabra) {
            double retorno = 0;
            if(!String.IsNullOrWhiteSpace(palabra) && palabra.Length > 0)
            {
                foreach (char caracter in palabra)
                {
                    if(caracter == ',' || caracter == '.' || caracter == ';')
                    {
                        retorno++;
                    }
                }
            }
            return retorno;
        }
    }
}
