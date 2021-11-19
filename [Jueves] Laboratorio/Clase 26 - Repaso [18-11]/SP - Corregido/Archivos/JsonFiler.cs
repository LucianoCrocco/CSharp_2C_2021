using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Archivos
{
    public class JsonFiler<T> : IMetodosArchivos<T>
    {
        public string GenerarRutaCompleta
        {
            get
            {
                return $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
            }
        }

        public bool ExisteArchivo(string nombreArchivo)
        {
            return File.Exists(this.GenerarRutaCompleta + nombreArchivo);
        }

        public void Guardar(string archivo, T objeto)
        {
            string path = this.GenerarRutaCompleta + archivo;
            try
            {
                StreamWriter sw = new StreamWriter(path);
                string aux;
                //File.WriteAllText()
                aux = JsonSerializer.Serialize(objeto);
                sw.WriteLine(aux);
                sw.Close();
            }
            catch(Exception ex)
            {
                throw new ErrorArchivosException("Error al guardar el archivo", ex);
            }
        }

        public void Leer(string archivo, out T objeto)
        {
            string path = this.GenerarRutaCompleta + archivo;
            try
            {
                string json = File.ReadAllText(path);
                objeto = (T)JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Error al cargar el archivo", ex);
            }
        }
    }
}
