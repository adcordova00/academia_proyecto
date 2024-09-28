using System;
using System.Windows.Forms;
using academia_proyecto.Models;
using academia_proyecto.Controllers;

namespace academia_proyecto.Views
{
    public partial class Conferencias : Form
    {
        private ConferenciasModel conferenciaActual;
        private ConferenciaController conferenciaController;
        public Conferencias()
        {
            InitializeComponent();
            conferenciaController = new ConferenciaController();
        }

        private void CargarListaConferencias()
        {
            lst_conferencias.Items.Clear();
            var conferencias = conferenciaController.ObtenerConferencias();

            foreach (var conferencia in conferencias)
            {
                lst_conferencias.Items.Add(conferencia);
            }
        }

        public void LimpiarForm() { 
            txt_nombre_conf.Text = string.Empty;
            txt_ubicacion_conf.Text = string.Empty;
            txt_descripcion_conf.Text = string.Empty;
            dtp_fecha_conf.Value = DateTime.Now;

            conferenciaActual = null;
        }


        private void btn_guardar_conf_Click(object sender, EventArgs e)
        {
            try
            {
                if (conferenciaActual == null)
                {
                    ConferenciasModel nuevaConferencia = new ConferenciasModel
                    {
                        Nombre = txt_nombre_conf.Text,
                        Fecha = dtp_fecha_conf.Value,
                        Ubicacion = txt_ubicacion_conf.Text,
                        Descripcion = txt_descripcion_conf.Text,
                    };
                    conferenciaController.AgregarConferencia(nuevaConferencia);
                    MessageBox.Show("Conferencia agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conferenciaActual.Nombre = txt_nombre_conf.Text;
                    conferenciaActual.Fecha = dtp_fecha_conf.Value;
                    conferenciaActual.Ubicacion = txt_ubicacion_conf.Text;
                    conferenciaActual.Descripcion = txt_descripcion_conf.Text;
                    conferenciaController.ActualizarConferencia(conferenciaActual);
                    MessageBox.Show("Conferencia modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarListaConferencias();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la Conferencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_conferencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_conferencias.SelectedItem != null)
            {
                ConferenciasModel seleccionada = (ConferenciasModel)lst_conferencias.SelectedItem;
                conferenciaActual = seleccionada;

                txt_nombre_conf.Text = seleccionada.Nombre;
                dtp_fecha_conf.Value = seleccionada.Fecha;
                txt_ubicacion_conf.Text = seleccionada.Ubicacion;
                txt_descripcion_conf.Text = seleccionada.Descripcion;
            }
        }

        private void Conferencias_Load(object sender, EventArgs e)
        {
            CargarListaConferencias();
        }

        private void btn_eliminar_conf_Click(object sender, EventArgs e)
        {
            if (lst_conferencias.SelectedItem != null)
            {

                string selectedItem = lst_conferencias.SelectedItem.ToString();
                int conferencia_id = int.Parse(selectedItem.Split('-')[0].Trim());

                try
                {
                    conferenciaController.EliminarConferencia(conferencia_id);
                    MessageBox.Show("Conferencia eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaConferencias();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la conferencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una conferencia para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_editar_conf_Click(object sender, EventArgs e)
        {
            if (lst_conferencias.SelectedItem != null)
            {
                conferenciaActual = lst_conferencias.SelectedItem as ConferenciasModel;

                if (conferenciaActual != null)
                {
                    txt_nombre_conf.Text = conferenciaActual.Nombre;
                    dtp_fecha_conf.Value = conferenciaActual.Fecha;
                    txt_ubicacion_conf.Text = conferenciaActual.Ubicacion;
                    txt_descripcion_conf.Text = conferenciaActual.Descripcion;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una conferencia para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
