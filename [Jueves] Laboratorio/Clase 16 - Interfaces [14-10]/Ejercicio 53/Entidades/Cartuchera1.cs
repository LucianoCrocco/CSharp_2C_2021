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
                item.UnidadesDeEscritura =- 1;
                if(item.UnidadesDeEscritura == 0)
                {
                    item.Recargar(20);
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
