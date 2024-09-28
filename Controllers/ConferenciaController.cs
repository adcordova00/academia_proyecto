using academia_proyecto.Models;
using Evaluacion_Parcial_2.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia_proyecto.Controllers
{
    public class ConferenciaController
    {
        public List<ConferenciasModel> ObtenerConferencias()
        {
            List<ConferenciasModel> conferencias = new List<ConferenciasModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT conferencia_id, nombre, fecha, ubicacion, descripcion FROM Conferencias";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ConferenciasModel conferencia = new ConferenciasModel
                    {
                        ID_Conferencia = Convert.ToInt32(reader["conferencia_id"]),
                        Nombre = reader["nombre"].ToString(),
                        Fecha = Convert.ToDateTime(reader["fecha"]),
                        Ubicacion = reader["ubicacion"].ToString(),
                        Descripcion = reader["descripcion"].ToString()
                    };
                    conferencias.Add(conferencia);
                }

                conn.Close();
            }
            return conferencias;
        }

        public void AgregarConferencia(ConferenciasModel conferencia)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Conferencias (nombre, fecha, ubicacion, descripcion) " +
                               "VALUES (@nombre, @fecha, @ubicacion, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", conferencia.Nombre);
                cmd.Parameters.AddWithValue("@fecha", conferencia.Fecha);
                cmd.Parameters.AddWithValue("@ubicacion", conferencia.Ubicacion);
                cmd.Parameters.AddWithValue("@descripcion", conferencia.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ActualizarConferencia(ConferenciasModel conferencia)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Conferencias SET nombre = @nombre, fecha = @fecha, ubicacion = @ubicacion, " +
                               "descripcion = @descripcion WHERE conferencia_id = @conferencia_id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@conferencia_id", conferencia.ID_Conferencia);
                cmd.Parameters.AddWithValue("@nombre", conferencia.Nombre);
                cmd.Parameters.AddWithValue("@fecha", conferencia.Fecha);
                cmd.Parameters.AddWithValue("@ubicacion", conferencia.Ubicacion);
                cmd.Parameters.AddWithValue("@descripcion", conferencia.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EliminarConferencia(int conferencia_id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Conferencias WHERE conferencia_id = @conferencia_id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@conferencia_id", conferencia_id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
