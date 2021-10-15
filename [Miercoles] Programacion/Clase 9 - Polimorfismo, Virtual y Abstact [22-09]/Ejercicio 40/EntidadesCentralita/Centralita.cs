using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCentralita
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Getters y Setters
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            foreach (Llamada llamada in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            retorno += ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            retorno += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    default:
                        if (llamada is Provincial)
                        {
                            retorno += ((Provincial)llamada).CostoLlamada;
                        }
                        else if (llamada is Local)
                        {
                            retorno += ((Local)llamada).CostoLlamada;
                        }
                        break;
                }
            }
            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tDATOS LLAMADAS A CENTRALITA");
            sb.AppendLine("Razon Social: " + this.razonSocial);
            sb.AppendLine("Ganancia por Total: " + this.CalcularGanancia(Llamada.TipoLlamada.Todas));
            sb.AppendLine("Ganancia por Local: " + this.CalcularGanancia(Llamada.TipoLlamada.Local));
            sb.AppendLine("Ganancia por Provincial: " + this.CalcularGanancia(Llamada.TipoLlamada.Provincial));
            sb.AppendLine("\tLISTA DE LLAMADOS");
            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        #endregion

        #region Sobreescritura Metodos
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Sobrecargas de operadores
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c is not null && nuevaLlamada is not null && c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            if(c is not null && llamada is not null)
            {
                foreach(Llamada llamadaRegistrada in c.listaDeLlamadas)
                {
                    if(llamadaRegistrada == llamada)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        #endregion
    }
}
