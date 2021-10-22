using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        #region Atributos
        private List<IAcciones> acciones;
        #endregion

        #region Constructores
        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>();
        }
        #endregion

        #region Metodos
        public bool ProbarMetodos()
        {
            foreach (IAcciones item in this.acciones){
                item.UnidadesDeEscritura -= 1;
                if(item.UnidadesDeEscritura < 0)
                {
                    item.Recargar(20);
                    return false;
                }
            }
            return true;
        }
        #endregion

        public static Cartuchera1 operator +(Cartuchera1 cartuchera, IAcciones obj)
        {
            try
            {
                cartuchera.acciones.Add(obj);
            }
            catch (Exception)
            {
                Console.WriteLine($"\a\tLa clase {obj.GetType().Name} no implementa la interfaz IAcciones");
                Console.ReadKey();
            }

            /*if(obj is not interface )? -> O no puedo hacer un if?
             */

            return cartuchera;
        }
    }
}
