using System;
using System.IO;


namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool retorno = false;
            if (validaExistencia)
            {
                if (!String.IsNullOrWhiteSpace(ruta))
                {
                    if (Directory.Exists(ruta))
                    {
                        retorno = true;
                    } else
                    {
                        throw new FileNotFoundException("El path indicado no existe!");
                    }
                } else
                {
                    throw new FileNotFoundException("El path indicado no existe!");
                }
            } 
            return retorno;
        }
    }
}
