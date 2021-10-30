using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesCentralita;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        private String connectionStr;
        private SqlCommand command;
        private SqlConnection connection;

        public LocalDAO(string nombreServidor, string nombreDataBase)
        {
            connectionStr = $"Data Source = {nombreServidor}; Initial Catalog = {nombreDataBase}; Integrated Security = True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionStr);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void Guardar (Llamada llamada)
        {
            try
            {
                command.CommandText = "INSERT INTO Llamadas VALUES (@Duracion,@Origen,@Destino,@Costo,@Tipo)";
                command.Connection.Open();
                command.Parameters.AddWithValue("Duracion", llamada.Duracion);
                command.Parameters.AddWithValue("Origen", llamada.NroOrigen);
                command.Parameters.AddWithValue("Destino", llamada.NroDestino);
                command.Parameters.AddWithValue("Costo", llamada.CostoLlamada);
                command.Parameters.AddWithValue("Tipo", 0);
                command.ExecuteNonQuery();
            }catch(Exception)
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
            command.CommandText = "SELECT Duracion, Origen, Destino, Costo, Tipo FROM Llamadas  WHERE Tipo = 0";
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                llamadas.Add(new Local(reader["Origen"].ToString(), int.Parse(reader["Duracion"].ToString()), reader["Destino"].ToString(), int.Parse(reader["Costo"].ToString())));
            }
            command.Connection.Close();
            command.Parameters.Clear();
            return llamadas;
        }
    }
}
