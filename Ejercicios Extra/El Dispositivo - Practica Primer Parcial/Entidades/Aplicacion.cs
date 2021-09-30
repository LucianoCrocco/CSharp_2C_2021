using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        protected abstract int Tamanio
        {
            get;
        }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion aplicacion = null;
            int maximo = int.MinValue;

            if (!(listaApp is null))
            {
                foreach (Aplicacion app in listaApp)
                {
                    if (app.Tamanio > maximo)
                    {
                        aplicacion = app;
                        maximo = app.Tamanio;
                    }
                }
            }
            return aplicacion;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion aplicacion)
        {
            bool retorno = false;
            if (listaApp is not null && aplicacion is not null && listaApp.Count > 0)
            {
                foreach (Aplicacion app in listaApp)
                {
                    if (app.nombre == aplicacion.nombre)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion aplicacion)
        {
            return !(listaApp == aplicacion);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion aplicacion)
        {
            if (listaApp is not null && aplicacion is not null && listaApp != aplicacion)
            {
                listaApp.Add(aplicacion);
                return true;
            }
            return false;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Sistema Operativo: " + this.SistemaOperativo);
            sb.AppendLine("Tamaño: " + this.Tamanio);

            return sb.ToString();
        }
    }
}
