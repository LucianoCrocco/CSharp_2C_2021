using System;

namespace Entidades
{
    public interface IArchivo<T>
    {
        void Guardar(T dato, string path, bool append);

        T Leer(string path);
    }
}
