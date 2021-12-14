using System;

namespace ConsolaEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Boton botonVerde = new Boton(1);
            Boton botonRojo = new Boton(2);
            Boton botonAmarillo = new Boton(3);

            Puerta puertaVerde = new Puerta("Verde");
            Puerta puertaRoja = new Puerta("Roja");
            Puerta puertaAmarilla = new Puerta("Amarilla");

            Cartel cartel = new Cartel();

            ConsoleKey tecla;

            // BOTON VERDE
            botonVerde.botonPresionado += puertaVerde.PuertaAbierta;
            botonVerde.botonPresionado += Lampara.PrenderFocoVerde;
            botonVerde.botonPresionado += cartel.IluminarCartel_1;

            //BOTON ROJO
            botonRojo.botonPresionado += puertaRoja.PuertaAbierta;
            botonRojo.botonPresionado += Lampara.PrenderFocoRojo;
            botonRojo.botonPresionado += cartel.IluminarCartel_2;

            // BOTON AMARILLO
            botonAmarillo.botonPresionado += puertaAmarilla.PuertaAbierta;
            botonAmarillo.botonPresionado += Lampara.PrenderFocoAmarillo;
            botonAmarillo.botonPresionado += cartel.IluminarCartel_3;



            do
            {

                Console.WriteLine("¿Que puerta desea abrir?");
                Console.WriteLine("1: Verde");
                Console.WriteLine("2: Roja");
                Console.WriteLine("3: Amarilla");

                tecla = Console.ReadKey(true).Key;

                switch (tecla)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        botonVerde.PresionarBoton();
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        botonRojo.PresionarBoton();
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.Clear();
                        botonAmarillo.PresionarBoton();
                        break;

                    default:
                        break;
                }

                System.Threading.Thread.Sleep(2000);
                Console.Clear();

            } while (true);


        }
    }
}
