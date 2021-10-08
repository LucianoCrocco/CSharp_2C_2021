using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        #region Atributos
        private PuestoAtencion caja;
        Queue<Cliente> clientes;
        private string nombre;
        #endregion

        #region Constructores
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Negocio n, Cliente c)
        {
            if(n.clientes.Count > 0)
            {
                foreach(Cliente cliente in n.clientes)
                {
                    if(cliente == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.clientes.Dequeue());
        }
        #endregion
    }
}
