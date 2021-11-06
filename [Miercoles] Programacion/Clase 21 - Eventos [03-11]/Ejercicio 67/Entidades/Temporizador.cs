using System;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void EncargadoTiempo();
    public class Temporizador
    {
        private Task hilo;
        private int intervalo;
        public event EncargadoTiempo EventoTiempo;

        public bool Activo
        {
            get
            {
                if(this.hilo is null)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
            set
            {
                if(value && Activo is false)
                {
                    this.hilo = new Task(Corriendo);
                    this.hilo.Start();
                }
                else if(value is false && Activo)
                {
                    this.hilo.Wait();
                }
            }
        }

        public int Intervalo { get => intervalo; set => intervalo = value; }



        public void Corriendo()
        {
            if(this.EventoTiempo is not null)
            {
                this.EventoTiempo.Invoke();
            }
            Thread.Sleep(this.Intervalo);
        }
    }
}
