using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region Atributos
        private DateTime fechaDeNacimiento;
        #endregion

        #region Constructores
        public DirectorTecnico(string nombre)
            : base(nombre)
        {
        }

        public DirectorTecnico(string nombre,  DateTime fechaDeNacimiento)
            : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        #endregion

        #region Sobrecarga De Operadores
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if(dt1.Nombre == dt2.Nombre && dt1.fechaDeNacimiento == dt2.fechaDeNacimiento)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
        #endregion

        #region Metodos
        public new string mostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.mostrarDatos());
            sb.AppendLine("OCUPACION: DIRECTOR TECNICO");
            sb.AppendLine("FECHA DE NACIMIENTO: " + this.fechaDeNacimiento);
            return sb.ToString();
        }
        #endregion
    }
}
