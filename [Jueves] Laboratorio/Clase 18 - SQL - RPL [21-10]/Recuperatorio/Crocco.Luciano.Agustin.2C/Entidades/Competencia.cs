using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        #region Atributos
        private int cantidaCompetidores;
        private List<Equipo> equipos;
        private string nombre;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado que utiliza al contstructor por defecto y setea la cantidad de competidores en 5
        /// </summary>
        /// <param name="nombre"></param>
        private Competencia(string nombre) : this(nombre, 5) {
        }

        /// <summary>
        /// Constructor por defecto, incializa la lista de equipos y recibe el nombre y la cantidad de competidores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidaCompetidores"></param>
        public Competencia(string nombre, int cantidaCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.CantidaCompetidores = cantidaCompetidores;
            this.Nombre = nombre;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna y asgina la cantida de competidores
        /// </summary>
        public int CantidaCompetidores
        {
            set
            {
                if (value > 0)
                {
                    this.cantidaCompetidores = value;
                }
            }
            get
            {
                return this.cantidaCompetidores;
            }
        }

        /// <summary>
        /// Devuelve la lista de equipo
        /// </summary>
        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
        }

        /// <summary>
        /// Asigna y retorna el nombre.
        /// </summary>
        public string Nombre
        {
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga implicita que crea una competicion con el nombre y utiliza el constructor privado
        /// </summary>
        /// <param name="nombre">Nombre de la competencia</param>
        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

        /// <summary>
        /// Comprueba si en el torneo se encuentra el mismo equipo contenido.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns>True si lo contiene False si no lo contiene</returns>
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            bool retorno = false;
            if(torneo is not null && equipo is not null)
            {
                foreach (Equipo item in torneo.Equipos)
                {
                    if (item == equipo)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
           
            return retorno;
        }

        /// <summary>
        /// Comprueba si en el torneo NO se encuentra el mismo equipo contenido.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns>Flase si lo contiene True si no lo contiene</returns>
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Si puede, suma el equipo a la competencia.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns>Retorna la competencia</returns>
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if(torneo is not null && equipo is not null)
            {
                if(torneo.CantidaCompetidores > torneo.Equipos.Count)
                {
                    if(torneo != equipo)
                    {
                        torneo.equipos.Add(equipo);
                    }
                }
            }
            return torneo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra losd atos del torneo
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre del torneo: " + torneo.Nombre);
            sb.AppendLine("Cantidad de competidores: " + torneo.CantidaCompetidores);
            sb.AppendLine("----Lista de Equipos participantes----");
            foreach(Equipo equipo in torneo.Equipos)
            {
                sb.AppendLine(equipo.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
