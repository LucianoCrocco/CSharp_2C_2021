using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        //Atributos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        List<AutoF1> competidores;

        //Constructores
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) 
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        //Sobrecarga de Operadores
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if(c.cantidadCompetidores > c.competidores.Count && c != a)
            {
                Random random = new Random();
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)random.Next(15, 100));
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if(c == a)
            {
                retorno = true;
            }

            return retorno;
        }
        
        //Metodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS COMPETENCIA\n");
            sb.AppendLine("CANTIDAD DE COMPETIDORES: " + this.cantidadCompetidores);
            sb.AppendLine("CANTIDAD DE VULETAS RESTANTES: " + this.cantidadVueltas);

            return sb.ToString();
        }
    }
}
