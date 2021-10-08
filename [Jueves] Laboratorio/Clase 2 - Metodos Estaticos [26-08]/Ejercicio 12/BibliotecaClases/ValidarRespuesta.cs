using System;

namespace BibliotecaClases
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool retorno = false;
            if (c == 'S' || c == 's')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
