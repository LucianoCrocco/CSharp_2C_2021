using System;
using System.Collections.Generic;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";

            List<int> lista = new List<int>();

            Stack<int> pilaPos = new Stack<int>();
            Stack<int> pilaNeg = new Stack<int>();

            Queue<int> colaPos = new Queue<int>();
            Queue<int> colaNeg = new Queue<int>();

            Random random = new Random();

            int numero;
            int cantidadACargar = 20;

            Console.WriteLine("\tCARGA DE NUMEROS EN LA LISTA");
            for(int i = 0; i < cantidadACargar; i++)
            {
                numero = random.Next(-100, 100);
                while(numero == 0)
                {
                    numero = random.Next(-100, 100);
                }
                lista.Add(numero);
            }

            foreach(int item in lista)
            {
                Console.WriteLine(item);
            }
            //for(int i = 0; i< 20; i++) SE PUEDE ACCEDER A UNA LISTA MEDIANTE UN INDICE
            //{
            //    Console.WriteLine(lista[i]);
            //}

            Console.WriteLine("\tNUMEROS POSITIVOS EN LA LISTA ORDENADOS EN FORMA DECRECIENTE");
            lista.Sort(OrdenarLista);
            foreach (int item in lista)
            {
                if(item > 0)
                {
                    pilaPos.Push(item);
                    colaPos.Enqueue(item);
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\tNUMEROS NEGATIVOS EN LA LISTA ORDENADOS EN FORMA CRECIENTE");
            foreach (int item in lista)
            {
                if (item < 0)
                {
                    pilaNeg.Push(item);
                    colaNeg.Enqueue(item);
                    Console.WriteLine(item);
                }
            }

            //for (int i = 0; i < 20; i++) //NO SE PUEDE ACCEDER A UN STACK Y UNA QUEUE A TRAVES DE UN INDICE
            //{
            //    Console.WriteLine(pilaNeg[i]);
            //    Console.WriteLine(colaNeg[i]);
            //}


            Console.WriteLine("\tNUMEROS POSITIVOS EN LA PILA ORDENADOS EN FORMA DECRECIENTE");

            foreach(int item in pilaPos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\tNUMEROS NEGATIVOS EN LA PILA ORDENADOS EN FORMA CRECIENTE");


            foreach (int item in pilaNeg)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\tNUMEROS POSITIVOS EN LA COLA ORDENADOS EN FORMA DECRECIENTE");

            Console.WriteLine(colaPos.Dequeue());
            //foreach (int item in colaPos)
            //{
            //    Console.WriteLine(item);
                
            //}

            Console.WriteLine("\tNUMEROS NEGATIVOS EN LA COLA ORDENADOS EN FORMA CRECIENTE");

            foreach (int item in colaNeg)
            {
                Console.WriteLine(item);
            }
        }

        public static int OrdenarLista(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a < b)
            {
                return 1;
            } else
            {
                return 0;
            }
        }

    }
}
