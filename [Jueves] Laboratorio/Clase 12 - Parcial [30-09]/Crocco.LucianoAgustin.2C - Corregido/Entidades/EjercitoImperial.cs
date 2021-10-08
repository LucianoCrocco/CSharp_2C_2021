using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        #region Atributos
        private List<Trooper> troopers;
        private int capacidad;

        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve la la coleccion de lista de troopers
        /// </summary>
        public List<Trooper> Troopers
        {
            get
            {
                return this.troopers;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto para inicializar la lista de troopers
        /// </summary>
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }

        /// <summary>
        /// Constructor de la clase Ejercito Imperial
        /// </summary>
        /// <param name="capacidad">Tamaño maximod disponible para la lista de troopers.</param>
        public EjercitoImperial(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }


        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Permite agregar troopers a la coleccion.
        /// </summary>
        /// <param name="ejercito">Objeto del tipo Ejercito Imperial</param>
        /// <param name="soldado">Objeto del tipo Trooper</param>
        /// <returns>Devuelve la lista con mi trooper agregado, si fue posible realizar la accion.</returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {
            if(ejercito is not null && soldado is not null)
            {
                if(ejercito.capacidad > ejercito.troopers.Count())
                {
                    ejercito.troopers.Add(soldado);
                }
            }
            return ejercito;
        }

        /// <summary>
        /// Permite quitar troopers a la coleccion.
        /// </summary>
        /// <param name="ejercito">Objeto del tipo Ejercito Imperial</param>
        /// <param name="soldado">Objeto del tipo Trooper</param>
        /// <returns>Devuelve la lista con mi trooper quitado, si fue posible realizar la accion.</returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {
            if (ejercito is not null && soldado is not null)
            {
                if (ejercito.troopers.Count() > 0)
                {
                    foreach(Trooper trooper in ejercito.troopers)
                    {
                        if(trooper.Equals(soldado))
                        {
                            ejercito.troopers.Remove(trooper);
                            break;
                        }
                    }
                }
            }
            return ejercito;
        }


        #endregion
    }
}
