using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita.Interfaces
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo
        { get; set; }

        void Guardar();

        T Leer();
    }
}
