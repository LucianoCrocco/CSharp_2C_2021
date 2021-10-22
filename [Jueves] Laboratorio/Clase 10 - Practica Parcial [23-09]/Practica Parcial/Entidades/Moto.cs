using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto : Vehiculo
    {
        public enum Etipo
        {
            Ciclomotor,
            Scooter,
            Sport
        }

        private Etipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, Etipo tipoMoto)
            :base(patente, horaIngreso)
        {
            this.tipo = tipoMoto;
        }

        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoEstacionamiento();
            }
        }

        protected override double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento() * Moto.valorHora;
        }

        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }


        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("TIPO DE MOTO: " + this.Descripcion);


            return sb.ToString();
        }


        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
