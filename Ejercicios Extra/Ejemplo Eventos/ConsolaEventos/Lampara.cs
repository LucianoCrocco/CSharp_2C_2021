using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaEventos
{
    public static class Lampara
    {
        public static void PrenderFocoVerde()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("LAMPARA PRENDIDA DE VERDE");
            Console.ResetColor();
        }
        public static void PrenderFocoRojo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LAMPARA PRENDIDA DE ROJO");
            Console.ResetColor();

        }
        public static void PrenderFocoAmarillo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LAMPARA PRENDIDA DE AMARILLO");
            Console.ResetColor();

            
        }
    }
}
