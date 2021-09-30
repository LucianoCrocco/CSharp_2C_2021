using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Trooper
    {
        #region Atributos
        public string vehiculo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve un string con el tipo (funcion en batalla) de nuestro trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de exploración";
            }
        }

        /// <summary>
        /// Retorna o asigna un vehiculo al trooper explorador
        /// </summary>
        public string Vehiculo
        {
            get
            {
                return this.vehiculo;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.vehiculo = "Indefinido";
                } else
                {
                    this.vehiculo = value;
                }
            }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de nuestro TrooperExplorador
        /// </summary>
        /// <param name="vehiculo">Tipo de vehiculo utilizado por el trooper</param>
        public TrooperExplorador(string vehiculo)
            :base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo; 
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve un string con la info del trooper
        /// </summary>
        /// <returns></returns>
        public override string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoTrooper());
            sb.AppendLine($"– Vehículo: {Vehiculo}");

            return sb.ToString();
        }
        #endregion

    }
}
