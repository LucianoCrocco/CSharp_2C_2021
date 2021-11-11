using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada(string mensaje);
    public class Carrera
    {
        private List<AutoF1> autos;
        private int kms;
        public event InformacionDeAvance InformarAvance;
        public event InformacionLlegada InformarLlegada;


        public Carrera() { }

        public Carrera(int kms)
        {
            this.Kms = kms;
            this.autos = new List<AutoF1>();
        }


        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public static Carrera operator +(Carrera carrera, AutoF1 autoF1)
        {
            if(carrera is not null && autoF1 is not null)
            {
                carrera.Autos.Add(autoF1);
            }
            return carrera;
        }

        public void IniciarCarrera()
        {
            GestorBaseDeDatos bsd = new GestorBaseDeDatos();
            GestorDeArchivos gda = new GestorDeArchivos("Resultados-carrera.txt");
            int contador = 0;
            
            if(this.InformarAvance is not null)
            {
                do
                {
                    foreach (AutoF1 item in this.Autos)
                    {
                        item.Acelerar();
                        this.InformarAvance.Invoke();
                        Thread.Sleep(10);
                        if (item.UbicacionEnPista > this.Kms && item.Posicion == 0)
                        {
                            contador++;
                            item.Posicion = contador;
                            try
                            {
                                bsd.Guardar(item);
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            try
                            {
                                ((IGuardar<AutoF1>)gda).Guardar(item);
                            }
                            catch (Exception)
                            {
                                throw;
                            }

                            if (this.InformarLlegada is not null)
                            {
                                this.InformarLlegada.Invoke(item.ToString());
                            }
                        }
                    }
                } while (contador < autos.Count);
            }
        }

    }
}
