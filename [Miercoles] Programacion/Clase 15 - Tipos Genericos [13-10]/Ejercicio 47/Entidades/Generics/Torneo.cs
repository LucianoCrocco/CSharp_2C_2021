using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> listaEquipos, Equipo equipo)
        {

            foreach (T item in listaEquipos.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool operator !=(Torneo<T> listaEquipos, Equipo equipo)
        {
            return !(listaEquipos == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> listaEquipos, Equipo equipo)
        {
            //CON IF
            /*if(typeof(T) == equipo.GetType())
            {
                listaEquipos.equipos.Add((T)equipo);
            } else
            {
                Console.WriteLine("\t\aEl equipo no pertenece a este torneo");
            } */
            // CON EXCEPCIONES
            try
            {
                listaEquipos.equipos.Add((T)equipo);
            }
            catch (Exception)
            {
                throw;
            }
            

            /*if (listaEquipos != equipo && listaEquipos.GetType() == equipo.GetType())//Hay alguna manera de comprobarlo o es necesario un enumerado como el ejercicio de competencias?
            {
                listaEquipos.equipos.Add((T)equipo);
            }
            else
            {
                //Console.WriteLine("El equipo no pertenece a este torneo");
                Console.WriteLine($"{listaEquipos.GetType()}{equipo.GetType()}");
                Console.ReadKey();
            }*/
            return listaEquipos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine($"--------- Lista de Equipos ---------");
            foreach (T items in this.equipos)
            {
                sb.AppendLine($"Nombre: {items.Nombre} --------- Fecha de Creacion: {items.FechaCreacion}");
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1 , T e2)
        {
            Random randomResultado = new Random();
            StringBuilder sb = new StringBuilder();
            int resultadoEquipo1;
            int resultadoEquipo2;

            resultadoEquipo1 = randomResultado.Next(0, 10);
            resultadoEquipo2 = randomResultado.Next(0, 10);

            sb.AppendLine($"{e1.Nombre} {resultadoEquipo1} vs {resultadoEquipo2} {e2.Nombre}");

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                if(equipos.Count > 2)
                {
                    Random random = new Random();
                    T e1 = equipos[random.Next(0, this.equipos.Count)];
                    T e2 = equipos[random.Next(0, this.equipos.Count)];
                    while (e1 == e2)
                    {
                        e2 = equipos[random.Next(0, this.equipos.Count)];
                    }
                    return CalcularPartido(e1, e2);
                }

                return "No hay suficientes equipos para simular un partido!";
            }
        }
    }
}
