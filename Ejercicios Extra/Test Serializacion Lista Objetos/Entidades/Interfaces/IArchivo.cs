using System;

namespace Entidades
{
    public interface IArchivo<T>
    {
        void Guardar(T dato, string path);

        T Leer(string path);
    }
}
