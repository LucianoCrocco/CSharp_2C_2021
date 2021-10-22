using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        #region Enumerados
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        #endregion

        #region Atributos

        private short cantidadCompetidores;
        private short cantidadVueltas;
        List<T> competidores;
        private TipoCompetencia tipo;

        #endregion

        #region Constructores

        private Competencia()
        {
            this.competidores = new List<T>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) 
            : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }

        #endregion

        #region Getters y Setters

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public T this [int i]
        {
            get
            {
                if(this.CantidadCompetidores >= i && this.competidores.Count <= i && !object.ReferenceEquals(this.competidores, null))
                {
                    return this.competidores[i];
                }
                return null;
            }
        }

        public List<T> Competidores
        {
            get { return this.competidores; }
        } 

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            //Dos maneras de hacerlo

            if (c.CantidadCompetidores > 0 && ((c.Tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) || (c.Tipo == TipoCompetencia.MotoCross && a is MotoCross)))
            {
                foreach (VehiculoDeCarrera vehiculoDeCarrera in c.Competidores)
                {
                    if (vehiculoDeCarrera == a)
                    {
                        return true;
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia.cs", "Sobrecarga ==");
            }
            return false;
        }

        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if( c is not null && a is not null && c.cantidadCompetidores > c.competidores.Count)
            {
                try
                {
                    if (c != a && ((c.Tipo == TipoCompetencia.F1 && a is AutoF1) || (c.Tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross))))
                    {
                        Random random = new Random();

                        //try catch si no tuviese ((c.Tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) || (c.Tipo == TipoCompetencia.MotoCross && a is
                        c.competidores.Add((T)a);

                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.CantidadVueltas;
                        a.CantidadCombustible = ((short)random.Next(15, 100));
                        retorno = true;
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Error al cargar el vehiculo a la competencia", "Competencia.cs", "Sobrecarga +", e);
                }
            } else
            {
                throw new CompetenciaNoDisponibleException("No hay espacios disponibles para agregar el vehiculo a la competencia", "Competencia.cs", "Sobrecarga ==");
            }
            return retorno;
        }

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if(c == a)
            {
                retorno = true;
                c.competidores.Remove((T)a);
            }

            return retorno;
        }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS COMPETENCIA\n");
            sb.AppendLine("TIPO DE COMPETENCIA: " + this.Tipo);
            sb.AppendLine("CANTIDAD DE COMPETIDORES: " + this.CantidadCompetidores);
            sb.AppendLine("CANTIDAD DE VULETAS RESTANTES: " + this.CantidadVueltas + "\n\n");

            foreach(VehiculoDeCarrera a in this.competidores)
            {
                sb.AppendLine(a.MostrarDatos());
            }

            return sb.ToString();
        }
        #endregion
    }
}
