using System;
using System.Windows.Forms;
using academia_proyecto.Views;

namespace academia_proyecto.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void conferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conferencias _conferencias = new Conferencias();
            _conferencias.ShowDialog();
        }

        private void asistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistentes _asistentes = new Asistentes();
            _asistentes.ShowDialog();
        }
    }
}
