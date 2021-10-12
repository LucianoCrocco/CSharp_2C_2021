using System;

namespace Test_Expeciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception;
            try
            {
                exception = new Exception("Exepcion");
            }
            catch(exception)
            {
                Console.WriteLine(exception.Message);
                if(exception is null)
                {
                    Console.WriteLine("Se desapilo");
                } else
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
