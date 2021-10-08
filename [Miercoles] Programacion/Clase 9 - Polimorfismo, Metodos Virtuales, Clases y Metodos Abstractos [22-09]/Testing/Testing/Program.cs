using System;
using Entidades;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;
            A a2 = new A();
            a.F();
            b.F();
            a.G();
            b.G();
            Console.WriteLine("----------------------");
            a2.F();
            a2.G();
            a2 = b;
            a2.F();
            a2.G();//Va a llamar al mas especifico de los overrides que hay en las clases
            Console.WriteLine("----------------------");
            C c = new C();
            c.F();
            c.G();
        }
    }
}
