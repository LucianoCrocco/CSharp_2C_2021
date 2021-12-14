using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEventos
{
    public class Boton
    {
        int idBoton;
        public event Action botonPresionado;

        public Boton(int id)
        {
            this.idBoton = id;
        }

        public void PresionarBoton()
        {
            botonPresionado.Invoke();
        }





    }
}
