using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class C : A
    {
        new public void F() { Console.WriteLine("C.F"); }
        public override void G() { Console.WriteLine("C.G.C"); }
    }
}
