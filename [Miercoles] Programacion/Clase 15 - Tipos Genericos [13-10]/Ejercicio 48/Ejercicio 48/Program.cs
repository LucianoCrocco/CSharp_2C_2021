using System;
using Entidades;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Factura factura = new Factura(10);
            Recibo recibo = new Recibo(100);

            contabilidad += factura;
            contabilidad += recibo;

            Console.WriteLine(contabilidad.MostrarDocumento());


        }
    }
}
