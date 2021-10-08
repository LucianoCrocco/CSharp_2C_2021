using System;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        #region Atributos
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;
        #endregion

        #region Constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador (int dni, string nombre)
            : this()
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
        
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) 
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region Getters y Setters

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
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
                return (float) this.TotalGoles / (float) this.PartidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }

            set
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }
        }

        #endregion

        #region Metodos

        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL JUGADOR");
            sb.AppendLine("DNI: " + this.DNI);
            sb.AppendLine("Nombre: " + this.Nombre);
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
            if (j1.dni == j2.dni)
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
