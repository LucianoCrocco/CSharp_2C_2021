using System;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private int partidosJugados;
        private int totalGoles;
        #endregion

        #region Constructores

        public Jugador (int dni, string nombre)
            : base(dni, nombre)
        {
        }
        
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) 
            : this(dni, nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }
        #endregion

        #region Getters y Setters

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                if (this.TotalGoles == 0)
                {
                    return 0;
                }
                return (float)this.TotalGoles / (float)this.PartidosJugados;
            }
        }
        #endregion

        #region Metodos

        public new string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.mostrarDatos());
            sb.AppendLine("OCUPACION: JUGADOR");
            sb.AppendLine("Patidos jugados: " + this.PartidosJugados);
            sb.AppendLine("Total de goles: " + this.TotalGoles);
            sb.AppendLine("Promedio de goles: " + this.PromedioGoles);
            //string retorno = ($"{this.dni}, {this.nombre}, {this.partidosJugados}, {this.totalGoles}, {this.GetPromedioGoles()}");
            //return retorno;
            return sb.ToString();//Otra manera de hacerlo con String Builder.
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.Dni == j2.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
