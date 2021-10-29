using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        private String connectionStr;
        private SqlCommand comando;
        private SqlConnection conexion;
        public PersonaDAO()
        {
            connectionStr = "Data Source=DESKTOP-; Initial Catalog=PersonaDataBase; Integrated Security=True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        public void Guardar(Persona persona)
        {
            try
            {
                comando.CommandText = "INSERT INTO Persona (Persona.Nombre, Persona.Apellido) VALUES (@Nombre, @Apellido)";
                conexion.Open();
                comando.Parameters.AddWithValue("Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("Apellido", persona.Apellido);
                comando.ExecuteNonQuery();
            } 
            catch(Exception ex) {
                throw new Exception("Error al guardar", ex);
            }
            finally
            {
                conexion.Close();
                comando.Parameters.Clear();
            }
        }


         public List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                comando.CommandText = "SELECT ID, Nombre, Apellido FROM Persona";
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //Otra forma de leer si tengo un contructor por defecto
                    /*Persona persona = new Persona();
                      persona.Id = int.Parse(reader["ID"].ToString());
                      persona.Nombre = reader["Nombre"].ToString();
                      persona.Apellido = reader["Apellido"].ToString();
                      personas.Add(persona);*/
                    /*Persona persona = new Persona();
                      persona.Id = int.Parse(reader[0].ToString());//Primer campo del select
                      persona.Nombre = reader[1].ToString();//Segundo campo del select
                      persona.Apellido = reader[2].ToString(); //Tercer campo del select
                      personas.Add(persona);*/

                    personas.Add(new Persona(int.Parse(reader["ID"].ToString()), reader["Nombre"].ToString(), reader["Apellido"].ToString()));

                }
                reader.Close();
                comando.ExecuteNonQuery();
            } 
            catch(Exception ex) {
                throw new Exception("Error al leer", ex);
            }
            finally
            {
                conexion.Close();
                comando.Parameters.Clear();
            }
            return personas;
        }

        public Persona LeerID(int id)
        {
            Persona persona = null;
            try
            {
                comando.CommandText = "SELECT * FROM Persona WHERE Persona.ID == id";
                comando.Connection.Open();
                SqlDataReader reader = comando.ExecuteReader();
                persona = new Persona(int.Parse(reader["ID"].ToString()), reader["Nombre"].ToString(), reader["Apellido"].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer", ex);
            }
            finally
            {
                comando.Connection.Close();
                comando.Parameters.Clear();
            }
            return persona;
        }

        public bool Modificar(Persona persona)
        {
            try
            {
                comando.CommandText = $"UPDATE Persona SET Persona.Nombre = @Nombre, Persona.Apellido = @Apellido WHERE (Persona.ID = @ID)";
                comando.Connection.Open();
                comando.Parameters.AddWithValue("Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("Apellido", persona.Apellido);
                comando.Parameters.AddWithValue("ID", persona.Id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar", ex);
            }
            finally
            {
                comando.Parameters.Clear();
                comando.Connection.Close();
            }
            return true;
        }

        public bool Borrar(int id) {
            try
            {
                comando.CommandText = $"DELETE FROM Persona WHERE ID = @ID" ;
                comando.Connection.Open();
                comando.Parameters.AddWithValue("ID", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al borrar", ex);
            }
            finally
            {
                comando.Connection.Close();
                comando.Parameters.Clear();
            }
            return true;
        }

    }
}
