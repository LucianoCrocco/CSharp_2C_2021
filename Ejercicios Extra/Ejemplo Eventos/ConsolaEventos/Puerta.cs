using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEventos
{
    public class Puerta
    {

        string nombrePuerta;

        public Puerta(string nombrePuerta)
        {
            this.nombrePuerta = nombrePuerta;
        }

        public void PuertaAbierta()
        {
            Console.WriteLine($"Puerta abierta: {nombrePuerta}");
        }
    }
}
