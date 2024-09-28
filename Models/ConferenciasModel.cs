using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia_proyecto.Models
{
    public class ConferenciasModel
    {
        public int ID_Conferencia { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"{ID_Conferencia} - {Nombre} - {Fecha.ToShortDateString()} - {Ubicacion}";
        }

        public ConferenciasModel() { }

        public ConferenciasModel(int conferencia_id, string nombre, DateTime fecha, string ubicacion, string descripcion)
        {
            ID_Conferencia = conferencia_id;
            Nombre = nombre;
            Fecha = fecha;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
        }
    }
}
