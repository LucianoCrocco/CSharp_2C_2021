using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntidadesCentralita;

namespace EntidadesDAO
{

    public class ProvincialDAO
    {
        private String connectionStr;
        private SqlCommand command;
        private SqlConnection connection;

        public ProvincialDAO(string nombreServidor, string nombreDataBase)
        {
            connectionStr = $"Data Source = {nombreServidor}; Initial Catalog = {nombreDataBase}; Integrated Security = True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionStr);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void Guardar(Llamada llamada)
        {
            try
            {
                command.CommandText = "INSERT INTO Llamadas VALUES (@Duracion,@Origen,@Destino,@Costo,@Tipo)";
                command.Connection.Open();
                command.Parameters.AddWithValue("Duracion", llamada.Duracion);
                command.Parameters.AddWithValue("Origen", llamada.NroOrigen);
                command.Parameters.AddWithValue("Destino", llamada.NroDestino);
                command.Parameters.AddWithValue("Costo", llamada.CostoLlamada);
                command.Parameters.AddWithValue("Tipo", 1);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
                command.Parameters.Clear();
            }
        }
        public List<Llamada> Leer()
        {
            List<Llamada> llamadas = new List<Llamada>();
            command.CommandText = "SELECT Duracion, Origen, Destino, Costo, Tipo FROM Llamadas  WHERE Tipo = 1";
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Provincial provincial = new Provincial(reader["Origen"].ToString(), Provincial.Franja.Franja_1, int.Parse(reader["Duracion"].ToString()), reader["Destino"].ToString());
                llamadas.Add();
            }
            command.Connection.Close();
            command.Parameters.Clear();
            return llamadas;
        }
    }
}
