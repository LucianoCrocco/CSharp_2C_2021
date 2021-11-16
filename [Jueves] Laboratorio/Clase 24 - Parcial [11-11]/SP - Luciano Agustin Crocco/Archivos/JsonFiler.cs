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
            string aux = this.GenerarRutaCompleta;
            if(File.Exists(aux + nombreArchivo))
            {
                return true;
            }
            return false;
        }

        public void Guardar(string archivo, T objeto)
        {
            
            try
            {
                StreamWriter sw = new StreamWriter(archivo);
                string aux;
                aux = JsonSerializer.Serialize(objeto);
                sw.WriteLine(aux);
            }catch(Exception ex)
            {
                throw new ErrorArchivosException("Error al guardar el archivo", ex);
            }
            finally
            {
                sw.Close();
            }
        }

        public void Leer(string archivo, out T objeto)
        {
            StreamReader sr = new StreamReader(archivo);
            string aux;
            try
            {
                aux = sr.ReadToEnd();
                objeto = (T)JsonSerializer.Deserialize(aux,typeof(T));
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Error al guardar el archivo", ex);
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
