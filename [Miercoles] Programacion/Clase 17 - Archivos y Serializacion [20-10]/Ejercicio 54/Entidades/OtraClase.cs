using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void Metodo()
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Una excepcion en OtraClase", ex);
            }
        }
    }
}
