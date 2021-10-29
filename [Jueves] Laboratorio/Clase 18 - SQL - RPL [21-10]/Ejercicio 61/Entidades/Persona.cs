using System;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int BuscarID(string aux)
        {
            int id = 0;
            int auxInt = 0;

            
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] > '9' || aux[i] < '0')
                {
                    auxInt = i;
                    break;
                }
            }
            aux = aux.ToString().Remove(auxInt);
            id = int.Parse(aux);
            
            return id;
        }
    }
}
