using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {

        #region Enumerados
        public enum ELiga{
            NBA,
            Euroleague,
            ACB
        }
        #endregion

        #region Atributos
        private ELiga liga;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, se le asgina un nombre y liga en NBA
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoBasket(string nombre) : this(nombre, ELiga.NBA) { }

        /// <summary>
        /// Constructor que recibe el nombre del equipo y el enumerado de la liga donde participa
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="liga"></param>
        public EquipoBasket(string nombre, ELiga liga) : base(nombre)
        {
            this.liga = liga;
        }
        #endregion

        #region Sobreescritura de Metodos
        /// <summary>
        /// Genera un numero de difcultad, dependiendo de la liga se asigna un rango de dificultad determinado 
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
            int retorno = 0;
            Random nroRandom = new Random();

            switch (this.liga)
            {
                case ELiga.NBA:
                    retorno = nroRandom.Next(8, 10);
                    break;
                case ELiga.Euroleague:
                    retorno = nroRandom.Next(5, 10);
                    break;
                default:
                    retorno = nroRandom.Next(1, 7);
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Muestra los datos de un equipo de basquet
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(" Basket-");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga que permite mostrar los datos de un equipo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
