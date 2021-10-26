using System;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        //XML transforma SOLO los atributos y propiedades de lectura-escritura públicas. (Lo podra guardar no lo podra leer)
        //Solo no me lo serializa y deserializa si mis propiedades son privadas, no le importa que el atributo sea privado.
        private string nombre;
        private string apellido;
        private int edad;
        
        //Para XML me pide un constructor sin parametros (por defecto) para ser serializada
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
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
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Edad: " + this.Edad);

            return sb.ToString();
        }
    }
}
