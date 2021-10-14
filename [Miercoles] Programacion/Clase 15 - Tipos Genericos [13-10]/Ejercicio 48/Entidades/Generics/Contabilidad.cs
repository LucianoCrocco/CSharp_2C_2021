using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public class Contabilidad<T, U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, T egreso)
        {
            contabilidad.egresos.Add(egreso);

            return contabilidad;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            contabilidad.ingresos.Add(ingreso);

            return contabilidad;
        }


        public string MostrarDocumento()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Items en T");
            foreach (T item in egresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }
            sb.AppendLine("");
            sb.AppendLine("Items en U");
            foreach (U item in ingresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            return sb.ToString();
        }
    }
}
