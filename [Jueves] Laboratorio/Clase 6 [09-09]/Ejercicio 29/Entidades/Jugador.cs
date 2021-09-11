using System;
using System.Text;

namespace Entidades
{
    public class Jugador
    {
        //Atributos
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        //Constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador (int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) 
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //Getters
        public float GetPromedioGoles()
        {
            if(this.totalGoles == 0)
            {
                return 0;
            }
            return this.partidosJugados / this.totalGoles;
        }

        //Metodos

        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DEL JUGADOR");
            sb.AppendLine("DNI: " + this.nombre);
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Patidos jugados: " + this.partidosJugados);
            sb.AppendLine("Total de goles: " + this.totalGoles);
            sb.AppendLine("Promedio de goles: " + this.GetPromedioGoles());
            //string retorno = ($"{this.dni}, {this.nombre}, {this.partidosJugados}, {this.totalGoles}, {this.GetPromedioGoles()}");
            //return retorno;
            return sb.ToString();//Otra manera de hacerlo con String Builder.
        }

        //Sobrecarga de Operadores
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
    }
}
