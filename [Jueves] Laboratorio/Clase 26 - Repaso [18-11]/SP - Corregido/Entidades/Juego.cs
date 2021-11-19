using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, short movimiento);
    public class Juego
    {
        private static short velocidad;
        private short ubicacion;
        private object controlVisual;
        public event InformacionDeAvance InformarAvance;

        public Juego() { }
        static Juego()
        {
            velocidad = 8;
        }

        public Juego(short ubicacion, object objetoVisual)
        {
            this.Ubicacion = ubicacion;
            this.ControlVisual = objetoVisual;
        }



        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        //Sin el static pq Json no serializa.
        public static short Velocidad {
            get
            {
                return velocidad;
            }
            set
            {
                if(value > 0)
                {
                    velocidad = value;
                }
            }
        }
        public short Ubicacion {
            get
            {
                return this.ubicacion;
            }
            set
            {
                this.ubicacion = value;
            }
        }

        public short Avanzar()
        {
            this.Ubicacion += Velocidad;
            return this.Ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel(CancellationToken token)
        {
            if (this.InformarAvance is not null)
            {
                do
                {
                    this.InformarAvance.Invoke(this, this.Avanzar());
                    System.Threading.Thread.Sleep(60 + Juego.velocidad);
                } while (token.IsCancellationRequested);
            }
        }

        public override string ToString()
        {
            return $"Velocidad = {Velocidad}, Ubicacion = {this.Ubicacion}";
        }
    }
}
