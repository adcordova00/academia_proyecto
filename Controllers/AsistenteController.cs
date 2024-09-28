using academia_proyecto.Models;
using Evaluacion_Parcial_2.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace academia_proyecto.Controllers
{
    public class AsistenteController
    {
        public List<AsistentesModel> ObtenerAsistentes()
        {
            List<AsistentesModel> asistentes = new List<AsistentesModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT a.asistente_id, a.nombre, a.apellido, a.email, a.telefono, a.conferencia_id, c.nombre AS nombre_conferencia " +
               "FROM Asistentes a " +
               "JOIN Conferencias c ON a.conferencia_id = c.conferencia_id"; ;
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AsistentesModel asistente = new AsistentesModel
                    {
                        ID_Asistente = Convert.ToInt32(reader["asistente_id"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Email = reader["email"].ToString(),
                        Telefono = reader["telefono"].ToString(),
                        ID_Conferencia = Convert.ToInt32(reader["conferencia_id"]),
                        NombreConferencia = reader["nombre_conferencia"].ToString()
                    };
                    asistentes.Add(asistente);
                }

                conn.Close();
            }
            return asistentes;
        }

        public void AgregarAsistente(AsistentesModel asistente)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Asistentes (nombre, apellido, email, telefono, conferencia_id) " +
                               "VALUES (@nombre, @apellido, @email, @telefono, @conferencia_id)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", asistente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", asistente.Apellido);
                cmd.Parameters.AddWithValue("@email", asistente.Email);
                cmd.Parameters.AddWithValue("@telefono", asistente.Telefono);
                cmd.Parameters.AddWithValue("@conferencia_id", asistente.ID_Conferencia);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ActualizarAsistente(AsistentesModel asistente)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Asistentes SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono, " +
                               "conferencia_id = @conferencia_id WHERE asistente_id = @asistente_id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@asistente_id", asistente.ID_Asistente);
                cmd.Parameters.AddWithValue("@nombre", asistente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", asistente.Apellido);
                cmd.Parameters.AddWithValue("@email", asistente.Email);
                cmd.Parameters.AddWithValue("@telefono", asistente.Telefono);
                cmd.Parameters.AddWithValue("@conferencia_id", asistente.ID_Conferencia);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EliminarAsistente(int asistente_id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Asistentes WHERE asistente_id = @asistente_id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@asistente_id", asistente_id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
