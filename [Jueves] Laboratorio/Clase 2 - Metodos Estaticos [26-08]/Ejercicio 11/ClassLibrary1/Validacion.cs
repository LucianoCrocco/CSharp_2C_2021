using System;

namespace ClassLibrary1
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = true;
            if (valor > max || valor < min)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
