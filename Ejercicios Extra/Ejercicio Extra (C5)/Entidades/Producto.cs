using System;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string codigoDeBarras;
        private string marca;
        private float precio;
        #endregion

        #region Constructores
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.precio = precio;
        }
        #endregion

        #region Getters y Setters
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
        }
        #endregion

        #region Metodos
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATOS PRODUCTO: ");
            sb.AppendLine("Marca: " + p.Marca);
            sb.AppendLine("Precio: " + p.Precio);

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Explicita
        public static explicit operator string(Producto p)
        {
            string retorno = p.codigoDeBarras;
            return retorno;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Producto p, string marca){
            if(p.Marca == marca)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.Marca == p2.Marca && ((string)p1) == ((string)p2) && !(p1 is null) && !(p2 is null))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
