using System;

namespace Entidades
{
    public interface IArchivo<T>
    {

        bool Guardar(T dato, string path);

        T Leer(string path);
    }
}
