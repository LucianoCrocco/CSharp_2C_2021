using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            string nombre;
            char SiNo;
            int valorHora;
            int antiguedad;
            int cantidadDeHorasTrabajadas;
            int sueldoAPagar;
            double descuento;
            double sueldoTotalAPagar;

            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el valor x hora trabajada del empleado: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out valorHora) == false || valorHora < 1)
                {
                    Console.Write("Error... Ingrese el valor x hora trabajada del empleado: ");
                    ingreso = Console.ReadLine();
                }

                Console.Write("Ingrese la cantidad de horas trabajadas del empleado: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out cantidadDeHorasTrabajadas) == false || cantidadDeHorasTrabajadas < 1)
                {
                    Console.Write("Error... Ingrese la cantidad de horas trabajadas del empleado: ");
                    ingreso = Console.ReadLine();
                }

                Console.Write("Ingrese la antiguedad del empleado: ");
                ingreso = Console.ReadLine();
                while (int.TryParse(ingreso, out antiguedad) == false || antiguedad < 1)
                {
                    Console.Write("Error... Ingrese la antiguedad del empleado: ");
                    ingreso = Console.ReadLine();
                }

                sueldoAPagar = cantidadDeHorasTrabajadas * valorHora;

                sueldoAPagar += (sueldoAPagar * 150);

                descuento = sueldoAPagar * 0.13;

                sueldoTotalAPagar = sueldoAPagar - descuento;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\nDATOS DEL EMPLEADO: Nombre: {nombre}, Antigüedad: {antiguedad}, Valor hora {valorHora}, Sueldo a pagar bruto: {sueldoAPagar}, Descuento {descuento}, Sueldo a pagar neto: {sueldoTotalAPagar}\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Si desea dejar de ingresar empleados ingrese la letra 'N'. Toque cualquier tecla para continuar: ");
                ingreso = Console.ReadLine();
                while (char.TryParse(ingreso, out SiNo) == false)
                {
                    Console.Write("ERORR... INGRESE SOLO UN CARACTER -> Si desea dejar de ingresar empleados ingrese la letra 'N'. Toque cualquier tecla para continuar: ");
                    ingreso = Console.ReadLine();
                }



            } while (SiNo != 'N');
        }
    }
}
