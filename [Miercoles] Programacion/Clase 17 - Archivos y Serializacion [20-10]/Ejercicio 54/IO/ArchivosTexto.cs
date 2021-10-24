using System;
using System.IO;

namespace IO
{
    public class ArchivosTexto
    {
        public static bool Guardar(string path, string info)
        {
            if (!String.IsNullOrWhiteSpace(path))
            {
                StreamWriter sw = new StreamWriter($"{path}");
                sw.WriteLine(info);
                sw.Close();
                return true;
            }
            return false;
        }

        public static string Leer(string path)
        {
            string retorno = "";
            if (!String.IsNullOrWhiteSpace(path))
            {
                StreamReader streamReader = new StreamReader($"{path}", System.Text.Encoding.UTF8);
                retorno = streamReader.ReadToEnd();
            }else
            {
                throw new FileNotFoundException();
            }
            return retorno;
        }
    }
}
