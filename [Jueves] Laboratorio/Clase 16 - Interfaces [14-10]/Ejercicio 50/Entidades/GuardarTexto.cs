using System;

namespace Entidades
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto leido", TypeCode.Object);
        }
    }
}
