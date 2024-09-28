using System;
using System.Linq;
using System.Windows.Forms;
using academia_proyecto.Controllers;
using academia_proyecto.Models;
using academia_proyecto.Views;

namespace academia_proyecto.Views
{
    public partial class Asistentes : Form
    {
        private AsistentesModel asistenteActual;
        private AsistenteController asistenteController;
        private ConferenciaController conferenciaController;
        public Asistentes()
        {
            InitializeComponent();
            asistenteController = new AsistenteController();
            conferenciaController = new ConferenciaController();
        }

        private void CargarListaAsistentes()
        {
            lst_asistentes.Items.Clear();
            var asistentes = asistenteController.ObtenerAsistentes();

            foreach (var asistente in asistentes)
            {
                lst_asistentes.Items.Add(asistente);
            }
        }

        private void CargarCBConferencias()
        {
            var conferencias = conferenciaController.ObtenerConferencias();

            foreach (var conferencia in conferencias)
            {
                cb_conferencia_asis.Items.Add(conferencia);
            }
        }

        public void LimpiarForm()
        {
            txt_nombre_asis.Text = string.Empty;
            txt_apellido_asis.Text = string.Empty;
            txt_email_asis.Text = string.Empty;
            txt_telefono_asis.Text = string.Empty;
            cb_conferencia_asis.SelectedIndex = -1;

            asistenteActual = null;
        }

        private void btn_guardar_asis_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_conferencia_asis.SelectedItem != null)
                {
                    ConferenciasModel conferenciaSeleccionada = cb_conferencia_asis.SelectedItem as ConferenciasModel;

                    if (asistenteActual == null)
                    {
                        AsistentesModel nuevoAsistente = new AsistentesModel
                        {
                            Nombre = txt_nombre_asis.Text,
                            Apellido = txt_apellido_asis.Text,
                            Email = txt_email_asis.Text,
                            Telefono = txt_telefono_asis.Text,
                            ID_Conferencia = conferenciaSeleccionada.ID_Conferencia 
                        };
                        asistenteController.AgregarAsistente(nuevoAsistente);
                        MessageBox.Show("Asistente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        asistenteActual.Nombre = txt_nombre_asis.Text;
                        asistenteActual.Apellido = txt_apellido_asis.Text;
                        asistenteActual.Email = txt_email_asis.Text;
                        asistenteActual.Telefono = txt_telefono_asis.Text;
                        asistenteActual.ID_Conferencia = conferenciaSeleccionada.ID_Conferencia; 

                        asistenteController.ActualizarAsistente(asistenteActual);
                        MessageBox.Show("Asistente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarListaAsistentes();
                    LimpiarForm();
                }
                else
                {
                    MessageBox.Show("Seleccione una conferencia válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el asistente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Asistentes_Load(object sender, EventArgs e)
        {
            CargarCBConferencias();
            CargarListaAsistentes();
        }

        private void lst_asistentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_asis_Click(object sender, EventArgs e)
        {
            if (lst_asistentes.SelectedItem != null)
            {
                AsistentesModel asistenteSeleccionado = lst_asistentes.SelectedItem as AsistentesModel;

                if (asistenteSeleccionado != null)
                {
                    asistenteActual = asistenteSeleccionado;

                    txt_nombre_asis.Text = asistenteSeleccionado.Nombre;
                    txt_apellido_asis.Text = asistenteSeleccionado.Apellido;
                    txt_email_asis.Text = asistenteSeleccionado.Email;
                    txt_telefono_asis.Text = asistenteSeleccionado.Telefono;

                    cb_conferencia_asis.SelectedItem = cb_conferencia_asis.Items
                        .Cast<ConferenciasModel>()
                        .FirstOrDefault(c => c.ID_Conferencia == asistenteSeleccionado.ID_Conferencia);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un asistente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_eliminar_asis_Click(object sender, EventArgs e)
        {
            if (lst_asistentes.SelectedItem != null)
            {

                string selectedItem = lst_asistentes.SelectedItem.ToString();
                int asistente_id = int.Parse(selectedItem.Split('-')[0].Trim());

                try
                {
                    asistenteController.EliminarAsistente(asistente_id);
                    MessageBox.Show("Asistente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaAsistentes();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el asistente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un asistente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_reporte_asis_Click(object sender, EventArgs e)
        {
            AsistentesReport _asistentesReport = new AsistentesReport();
            _asistentesReport.ShowDialog();
        }
    }
}
