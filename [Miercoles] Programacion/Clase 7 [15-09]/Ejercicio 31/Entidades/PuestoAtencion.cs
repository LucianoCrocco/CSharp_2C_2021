using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    

    public class PuestoAtencion
    {
        #region Enumerados
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        #endregion

        #region Atributos
        private static int numeroActual;
        Puesto puesto;
        #endregion


        #region Constructores
        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        #endregion

        #region Getters y Setters
        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }
        #endregion


        #region Metodos
        public bool Atender(Cliente cli)
        {
            int esperaEnCola = NumeroActual;
            Console.WriteLine(esperaEnCola);
            Thread.Sleep(3000);
            return true;
            
        }

        #endregion
    }
}
