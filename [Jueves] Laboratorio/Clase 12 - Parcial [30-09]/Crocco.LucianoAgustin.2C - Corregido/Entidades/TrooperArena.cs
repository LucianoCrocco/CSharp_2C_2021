using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Trooper
    {
        #region Propiedades
        /// <summary>
        /// Devuelve un string con el tipo (funcion en batalla) de nuestro trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldados de asalto de terrenos desérticos";
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase TrooperArena
        /// </summary>
        /// <param name="armamento">Tipo de armamento que utilizará nuestro trooper</param>
        public TrooperArena(Blaster armamento)
            : base(armamento) { }

        #endregion
    }
}
