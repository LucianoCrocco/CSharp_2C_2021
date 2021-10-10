using System;

namespace Entidades
{
    public class Sobrescrito
    {

        public override string ToString()
        {
            return "Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
