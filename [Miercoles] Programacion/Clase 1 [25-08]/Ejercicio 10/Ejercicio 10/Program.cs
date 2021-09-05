using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            string ingreso;
            string espacios;
            int altura;
            char caracter = '*';
            int acumulador = 1;
            int acumuladorEspacios = 1;

            Console.Write("Ingrese la altura de la piramide a imprimir (La altura debe ser mayor a 0): ");
            ingreso = Console.ReadLine();

            while (int.TryParse(ingreso, out altura) == false || altura < 1)
            {
                Console.Write("ERROR... Ingrese solo numeros que sean mayores a 0: ");
                ingreso = Console.ReadLine();
            }

            acumuladorEspacios = altura;
            for (int i = 0; i < altura; i++)
            {
                if(i == 0){
                    espacios = new String(' ', acumuladorEspacios);
                    Console.Write($"{espacios}{caracter}");
                } else
                {
                    acumuladorEspacios -= 1;
                    acumulador += 2;
                    for(int j = 0; j < acumulador; j++)
                    {
                        if(j== 0 && i != 0)
                        {
                            Console.Write("\n");
                            espacios = new String(' ', acumuladorEspacios);
                            Console.Write($"{espacios}");
                        }
                        Console.Write($"{caracter}");
                    }
                }
            }
        }
    }
}


//for (int i = 0; i < altura; i++)
//{
//    if (i == 0)
//    {
//        espacios = new String(' ', acumuladorEspacios);
//        Console.Write($"{espacios}{caracter}");
//    }
//    else
//    {
//        acumuladorEspacios += 1;
//        acumulador += 2;
//        for (int j = 0; j < acumulador; j++)
//        {
//            if (j == 0 && i != 0)
//            {
//                Console.Write("\n");
//                espacios = new String(' ', acumuladorEspacios);
//                Console.Write($"{espacios}");
//            }
//            Console.Write($"{caracter}");
//        }
//    }