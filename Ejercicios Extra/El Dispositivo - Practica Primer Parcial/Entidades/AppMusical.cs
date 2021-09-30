using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        protected override int Tamanio
        {
            get
            {
                int acumulador = 0;
                acumulador = listaCanciones.Count * 2;
                return this.tamanioMb + acumulador;
            }
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            : this(nombre, sistemaOperativo, tamanioInicial, new List<string>()) 
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            :base(nombre, sistemaOperativo, tamanioInicial) 
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("\t---Lista de Canciones---");
            foreach(string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }

            return sb.ToString();
        }
    }
}
