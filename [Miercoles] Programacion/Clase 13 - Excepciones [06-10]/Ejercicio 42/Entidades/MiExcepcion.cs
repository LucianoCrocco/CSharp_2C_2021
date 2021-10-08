using System;

namespace Entidades
{
    public class MiExpecion : Exception
    {
        public MiExpecion(string message) : base(message)
        {
        }

        public MiExpecion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
