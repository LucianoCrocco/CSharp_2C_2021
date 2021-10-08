using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            } else if( Estacionamiento.estacionamiento is not null)
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }

            return Estacionamiento.estacionamiento;
        }

        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string InformarSalida(Vehiculo v1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre del estacionamiento: " + Estacionamiento.estacionamiento.nombre);
            sb.AppendLine(v1.ToString());
            sb.AppendLine("HORA EGRESO: " + v1.HoraEgreso);
            sb.AppendLine("TOTAL A PAGAR: " + v1.CostoEstadia);

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(!(estacionamiento is null) && !(vehiculo is null) && estacionamiento.listadoVehiculos.Count > 0)
            {
                foreach(Vehiculo v in estacionamiento.listadoVehiculos)
                {
                    if(v == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }


        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.capacidadEstacionamiento > estacionamiento.listadoVehiculos.Count && estacionamiento != vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.capacidadEstacionamiento > estacionamiento.listadoVehiculos.Count && estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            Estacionamiento estacionamiento = obj as Estacionamiento;

            return !(estacionamiento is null) && estacionamiento == this;
        }

        public override int GetHashCode()
        {
            return (listadoVehiculos).GetHashCode();
        }
    }
}
