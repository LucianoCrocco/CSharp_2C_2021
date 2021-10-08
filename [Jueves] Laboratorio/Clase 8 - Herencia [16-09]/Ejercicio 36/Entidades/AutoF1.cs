using System;

using System.Text;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos
        private short caballosDeFuerza;
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia) 
            :base(numero, escuderia){
            base.CantidadCombustible = 0;
            base.EnCompetencia = false;
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :base(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        #endregion

        #region Getters y Setters
        public short CaballosDeFuerza
        {
            set
            {
                this.caballosDeFuerza = value;
            }
            get
            {
                return this.caballosDeFuerza;
            }
        }

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if((VehiculoDeCarrera) a1 == (VehiculoDeCarrera) a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Metodos

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("CABALLOS DE FUERZA: " + this.CaballosDeFuerza);
            sb.AppendLine("TIPO DE VEHICULO DE CARRERA: AUTO FORMULA 1");
            return sb.ToString();
        }
        #endregion
    }
}
