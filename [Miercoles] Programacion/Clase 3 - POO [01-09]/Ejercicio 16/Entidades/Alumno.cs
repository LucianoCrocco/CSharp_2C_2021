using System;

namespace Entidades
{
    public class Alumno
    {
       
        private int nota1;
        private int nota2;
        private int notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        // En el ejercicio en cuestion no habia que usar un constructor ya que tenemos atributos publicos
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        } 

        public void Estudiar(int nota1, int nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            this.notaFinal = -1;
            Random randomObj = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = randomObj.Next(4, 10);
            }
        }

        public string Mostrar()
        {
            string retorno;
            if(this.notaFinal != -1){
                //retorno = ($"Nombre {this.nombre}, apellido {this.apellido}, legajo {this.legajo}, nota final {this.notaFinal}");
                retorno = String.Format($"Nombre {this.nombre}, apellido {this.apellido}, legajo {this.legajo}, nota final {this.notaFinal}");
            } else
            {
                retorno = "Alumno desaprobado";
            }
            return retorno;
        }
    }
}
