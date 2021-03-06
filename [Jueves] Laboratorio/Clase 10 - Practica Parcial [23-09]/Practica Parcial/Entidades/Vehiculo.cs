using System;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos{
            Automovil,
            Moto
        }
        private DateTime horaIngreso;
        private string patente;
        private DateTime horaEgreso;


        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.patente = patente;
            this.horaIngreso = horaIngreso;
        }

        public abstract string Descripcion
        {
            get;
        }

        public abstract double CostoEstadia
        {
            get;
        }

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if(value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }
        
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        private static bool ValidarPatente(string patente)
        {
            bool retorno = true;

            if (!String.IsNullOrWhiteSpace(patente) && (patente.Length < 6 || patente.Length > 7))
            { 
                retorno = false;
            }
            return retorno;
        }

        protected virtual double CargoEstacionamiento()
        {
            double retorno = 0;
            if(this.HoraEgreso.Hour > this.HoraIngreso.Hour)
            {
                retorno = this.HoraEgreso.Hour - this.HoraIngreso.Hour;
            }
            return retorno; 
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de vehiculo: " + this.GetType().Name);
            sb.AppendLine("PATENTE: " + this.Patente);
            sb.AppendLine("HORA DE INGRESO: " + this.HoraIngreso.Hour);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(!(v1 is null) && !(v2 is null) && v1.Patente == v2.Patente)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            Vehiculo vehiculo = obj as Vehiculo;

            return !(vehiculo is null) && this == vehiculo;
        }

        public override int GetHashCode()
        {
            return (patente).GetHashCode();
        }
    }
}
