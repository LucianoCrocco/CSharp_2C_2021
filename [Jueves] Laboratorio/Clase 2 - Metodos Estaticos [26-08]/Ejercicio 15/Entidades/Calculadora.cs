using System;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(int num1, int num2, char operador)
        {


            if(operador == '/')
            {
                if(ValidarOperador(num2)!= false)
                {
                    Console.Write("No se puede dividir por cero");
                } else
                {
                    return num1 / num2;
                }
            }

            switch (operador)
            {
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                default:
                    return num1 + num2;
            }
        }

        private static bool ValidarOperador(int num2)
        {
            if(num2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
