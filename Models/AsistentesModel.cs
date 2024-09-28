using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia_proyecto.Models
{
    public class AsistentesModel
    {
        public int ID_Asistente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int ID_Conferencia { get; set; }

        public string NombreConferencia { get; set; }

        public override string ToString()
        {
            return $"{ID_Asistente} - {Nombre} - {Apellido} - {Email} - {Telefono} - {NombreConferencia}";
        }

        public AsistentesModel() { }

        public AsistentesModel(int asistente_id, string nombre, string apellido, string email, string telefono, int conferencia_id)
        {
            ID_Asistente = asistente_id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            ID_Conferencia = conferencia_id;
        }
    }
}
