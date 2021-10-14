using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime creacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = creacion;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} fundado en {this.FechaCreacion}");
            return sb.ToString();
        }
    }
}
