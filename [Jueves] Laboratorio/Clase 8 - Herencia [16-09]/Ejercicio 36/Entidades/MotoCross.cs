using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos
        private short cilindrada;
        #endregion

        #region Constructores
        public MotoCross(short numero, string escuderia)
            :base(numero, escuderia){
            base.CantidadCombustible = 0;
            base.EnCompetencia = false;
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion

        #region Getters y Setters
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if( (VehiculoDeCarrera) m1 == (VehiculoDeCarrera) m2 && m1.Cilindrada == m2.Cilindrada)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        #endregion

        #region Metodos
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("CILINDRADA: " + this.Cilindrada);
            sb.AppendLine("TIPO DE VEHICULO DE CARRERA: MOTOCROSS");
            return sb.ToString();
        }

        #endregion
    }
}
