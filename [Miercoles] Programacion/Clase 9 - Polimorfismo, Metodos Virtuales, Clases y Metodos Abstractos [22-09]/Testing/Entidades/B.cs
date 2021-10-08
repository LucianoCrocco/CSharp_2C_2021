using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class B : A
    {
        new public void F() { Console.WriteLine("B.F"); }
    }
}
