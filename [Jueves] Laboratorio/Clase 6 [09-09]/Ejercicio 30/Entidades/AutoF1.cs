using System;

using System.Text;

namespace Entidades
{
    public class AutoF1
    {
        //Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        //Constructores
        public AutoF1(short numero, string escuderia)
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }
        
        //Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //Getters y Setters
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }


        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }


        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        //Metodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS AUTO F1\n");
            sb.AppendLine("NUMERO: " + this.numero);
            sb.AppendLine("ESCUDERIA: " + this.escuderia);
            sb.AppendLine("CANTIDAD DE COMBUSTIBLE: " + this.cantidadCombustible);
            sb.AppendLine("VUELTAS RESTANTES: " + this.vueltasRestantes);
            sb.AppendLine("¿EN COMPETENCIA?: " + this.enCompetencia);

            return sb.ToString();
        }
    }
}
