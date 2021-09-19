using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Atributos
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region Constructores
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region Getters y Setters
        public Producto[] Productos{
            get
            {
                return this.productos;
            }
        }
        #endregion

        #region Metodos
        public static string MostrarEstante (Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UBICACION ESTANTE: " + e.ubicacionEstante);
            sb.AppendLine("PRODUCTOS EN EL ESTANTE: ");
            foreach(Producto producto in e.Productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Estante e, Producto p)
        {
            foreach(Producto producto in e.Productos)
            {
                if(producto == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p){
                for(int i = 0; i < e.Productos.Length; i++)
                {
                    if (e.Productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true; ;
                    }
                }
            }
            return false;
        }

        public static bool operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for(int i = 0; i < e.Productos.Length; i++)
                {
                    if(e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
