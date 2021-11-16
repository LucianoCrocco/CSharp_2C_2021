using System;

namespace Archivos
{
    public interface IMetodosArchivos<T>
    {
        string GenerarRutaCompleta { get; }

        bool ExisteArchivo(string nombreArchivo);
        void Guardar(string archivo, T objeto);
        void Leer(string archivo, out T objeto); 
    }
}
