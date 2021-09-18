using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        private long dni;
        private string nombre;
        #endregion

        #region Constructores
        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
        public Persona(long dni, string nombre )
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
        #endregion

        #region Getters y Setters
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Metodos
        public string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS DE LA PERSONA");
            sb.AppendLine("DNI: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);
            return sb.ToString();
        }
        #endregion
    }
}
