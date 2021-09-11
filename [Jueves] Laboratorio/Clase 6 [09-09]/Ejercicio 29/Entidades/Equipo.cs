using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {   
        //Atributo
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        //Constructores
        private Equipo()
        {
            //List<Jugador> jugadores = new List<Jugador>(); MAL, se debe inicializar com se hizo abajo
            jugadores = new List<Jugador>(); //Inicializacion.
        }

        public Equipo(short cantidad, string nombre) 
            : this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidad;
        }

        //Sobrecarga de Operadores
        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count() < e.cantidadDeJugadores)
            {
                foreach(Jugador jugador in e.jugadores)
                {
                    if(jugador == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
