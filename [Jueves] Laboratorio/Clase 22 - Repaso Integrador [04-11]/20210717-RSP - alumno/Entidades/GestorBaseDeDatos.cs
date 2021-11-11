using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorBaseDeDatos : IGuardar<AutoF1>
    {
        private static string cadenaConexion;

        static GestorBaseDeDatos() {
            cadenaConexion = $"Data Source=DESKTOP-0KPPBQN;Initial Catalog=20210717-RSP;Integrated Security=True";
        }

        public void Guardar(AutoF1 tipo)
        {
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = sqlConnection;
            try
            {
                comando.Connection.Open();
                comando.CommandText = "INSERT INTO resultados * VALUES @Escuderia, @Velocidad, @UbicacionEnPista";
                comando.Parameters.AddWithValue("Escuderia", tipo.Escuderia);
                comando.Parameters.AddWithValue("Velocidad", tipo.Velocidad);
                comando.Parameters.AddWithValue("UbicacionEnPista", tipo.UbicacionEnPista);
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Connection.Close();
                comando.Parameters.Clear();
            }
        }
    }
}
