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
            int antiguedad;
            int cantidadDeHorasTrabajadas;

            int acumualdorAntiguedad = 0;
            int acumuladorCantidadDeHorasTrabajadas = 0;

            do
            {
                Console.Write("Si desea dejar de ingresar empleados ingrese la letra 'N'. Toque cualquier tecla para continuar: ");
                ingreso = Console.ReadLine();
                while (char.TryParse(ingreso, out SiNo) == false)
                {
                    Console.Write("ERORR... INGRESE SOLO UN CARACTER -> Si desea dejar de ingresar empleados ingrese la letra 'N'. Toque cualquier tecla para continuar: ");
                    ingreso = Console.ReadLine();
                }

                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

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

                acumualdorAntiguedad += antiguedad;
                acumuladorCantidadDeHorasTrabajadas += cantidadDeHorasTrabajadas;

            } while (SiNo != 'N');
        }
    }
}
