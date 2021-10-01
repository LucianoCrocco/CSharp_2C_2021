using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Trooper
    {
        #region Propiedades
        /// <summary>
        /// Devuelve un string con el tipo (funcion en batalla) de nuestro trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Comando para misiones de infiltración";
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase TrooperAsalto
        /// </summary>
        /// <param name="armamento">Tipo de armamento que utilizará nuestro trooper</param>
        public TrooperAsalto (Blaster armamento)//Correcion, me confundi con el Trooper Arena.
            : base(armamento, true) { }

        #endregion
    }
}
