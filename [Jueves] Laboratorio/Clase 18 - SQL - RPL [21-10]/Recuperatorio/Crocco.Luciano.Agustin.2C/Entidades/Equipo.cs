using System;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        #region Atributos
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de un equipo
        /// </summary>
        /// <param name="nombre">Nombre del equipo</param>
        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Devuelve el nombre de un equipo
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Devuelve y setea los partidos empatados de un equipo
        /// </summary>
        public int PE
        {
            get
            {
                return this.partidosEmpatados;
            }

            set
            {
                if(value > -1)
                {
                    this.partidosEmpatados = value;
                }
            }
        }
        /// <summary>
        /// Devuelve y setea los partidos ganados de un equipo
        /// </summary>
        public int PG
        {
            get
            {
                return this.partidosGanados;
            }

            set
            {
                if (value > -1)
                {
                    this.partidosGanados = value;
                }
            }
        }
        /// <summary>
        /// Devuelve y setea los partidos jugados de un equipo
        /// </summary>
        public int PJ
        {
            get
            {
                return this.partidosJugados;
            }

            set
            {
                if (value > -1)
                {
                    this.partidosJugados = value;
                }
            }
        }
        /// <summary>
        /// Devuelve y setea los partidos perdidos de un equipo
        /// </summary>
        public int PP
        {
            get
            {
                return this.partidosPerdidos;
            }

            set
            {
                if (value > -1)
                {
                    this.partidosPerdidos = value;
                }
            }
        }
        /// <summary>
        /// Devuelve y setea la puntuacion de un equipo
        /// </summary>
        public int Puntuacion
        {
            get
            {
                return this.puntuacion;
            }

            set
            {
                if (value > -1)
                {
                    this.puntuacion = value;
                }
            }
        }

        /// <summary>
        /// Devuelve el tipo de equipo que es en la instancia.
        /// </summary>
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        #endregion

        #region Sobrecarga de Metodos
        /// <summary>
        /// Comprueba que la instancia actual sea del mismo tipo al objeto por parametros
        /// </summary>
        /// <param name="obj">Objeto a comparar con la instancia actual</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Recibe por parametros dos objetos y compara que contengan el mismo Nombre y Tipo 
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns>True si son iguales - False si es distinto</returns>
        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Nombre == equipoB.Nombre && equipoA.Tipo == equipoB.Tipo;
        }

        /// <summary>
        /// Recibe por parametros dos objetos y compara que los mismos contienen distinto Nombre y Tipo
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns>False si son iguales - True si es distinto</returns>
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de la instancia del equipo
        /// </summary>
        /// <returns>string con la informacion a mostrar</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Nombre);

            return sb.ToString();
        }
        /// <summary>
        /// Simula un partido entre A y B
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns>True si se pudo jugar - False si no se pudo jugar.</returns>
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool retorno = false;
            if(equipoA is not null && equipoB is not null)
            {
                if (equipoA.Equals(equipoB))
                {
                    equipoA.PJ += 1;
                    equipoB.PJ += 1;
                    if (equipoA.GetDificultad() > equipoB.GetDificultad())
                    {
                        equipoA.PG += 1;
                        equipoB.PP += 1;
                        equipoA.Puntuacion += 3;
                    }
                    else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                    {
                        equipoB.PG += 1;
                        equipoA.PP += 1;
                        equipoB.Puntuacion += 3;
                    } else
                    {
                        equipoB.PE += 1;
                        equipoA.PE += 1;
                        equipoB.Puntuacion += 1;
                        equipoA.Puntuacion += 1;
                    }
                    retorno = true;
                }
            }
            return retorno;
        }


        public abstract int GetDificultad();
        #endregion
    }
}
