using System;

namespace Test_Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            A ab = new B();
            A ac = new C();
            A ad = new D();

            ab.F();
            ac.F();
            ad.F();
        }
    }
    public abstract class A
    {
        public abstract void F();
    }
    public  class B : A
    {
        public override void F()
        {
            Console.WriteLine("ASD12312312");
        }
    }

    public class C : B
    {
        public override void F()
        {
            Console.WriteLine("ASD");
        }
    }

    public class D : C
    {

    }
}
