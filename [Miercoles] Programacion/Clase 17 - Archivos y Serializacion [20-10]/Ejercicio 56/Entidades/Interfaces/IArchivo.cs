using System;

namespace Entidades
{
    public interface IArchivo<T>
    {
        string RutaDeArchivo { get; set; }

        bool Guardar(T dato, string path);

        T Leer(string path);
    }
}
