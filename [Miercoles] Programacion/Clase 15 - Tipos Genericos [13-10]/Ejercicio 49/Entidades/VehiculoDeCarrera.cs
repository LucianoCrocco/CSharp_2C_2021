using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoDeCarrera
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Constructores
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        #endregion

        #region Getters y Setters

        public short CantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
            get
            {
                return this.cantidadCombustible;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }



        public string Escuderia
        {
            set
            {
                this.escuderia = value;
            }
            get
            {
                return this.escuderia;
            }
        }

        public short Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

        #region Sobrecarga De Operadores
        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            if(v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }



        #endregion

        #region Metodos
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS VEHICULOS DE CARRERA\n");
            sb.AppendLine("NUMERO: " + this.Numero);
            sb.AppendLine("ESCUDERIA: " + this.Escuderia);
            sb.AppendLine("CANTIDAD DE COMBUSTIBLE: " + this.CantidadCombustible);
            sb.AppendLine("VUELTAS RESTANTES: " + this.VueltasRestantes);
            sb.Append("¿EN COMPETENCIA?: " + this.EnCompetencia);

            return sb.ToString();
        }
        #endregion


    }
}
