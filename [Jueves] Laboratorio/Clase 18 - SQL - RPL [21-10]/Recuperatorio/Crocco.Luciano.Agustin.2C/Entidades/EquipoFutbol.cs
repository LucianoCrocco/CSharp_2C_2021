using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        #region Atributos
        private bool jugadoresEstrella;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de un Equipo de Futbol. No tiene jugadores estrellas
        /// </summary>
        /// <param name="nombre"></param>
        public EquipoFutbol(string nombre) : this(nombre, false) { }

        /// <summary>
        /// Constructor que recibe nombre y si tiene o no estrellas en el equipo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="jugadoresEstrella"></param>
        public EquipoFutbol(string nombre, bool jugadoresEstrella) : base(nombre){
            this.jugadoresEstrella = jugadoresEstrella;
        }
        #endregion

        #region Sobreescritura de Metodos
        /// <summary>
        /// Genera un numero de difcultad, si la instancia tiene jugadores estrellas ese numero se multiplica por 2 
        /// </summary>
        /// <returns>El numero que se genero</returns>
        public override int GetDificultad()
        {
            int retorno = 0;
            Random nroRandom = new Random();
            retorno = nroRandom.Next(7, 10);

            if (this.jugadoresEstrella)
            {
                retorno *= 2;
            }

            return retorno;
        }
        /// <summary>
        /// Muestra los datos de un equipo de futbol
        /// </summary>
        /// <returns>string con los datos a mostrar</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(" Futbol-");
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
