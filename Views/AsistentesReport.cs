using academia_proyecto.Controllers;
using academia_proyecto.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace academia_proyecto.Views
{
    public partial class AsistentesReport : Form
    {
        AsistenteController asistenteController;
        public AsistentesReport()
        {
            InitializeComponent();
            asistenteController = new AsistenteController();
        }
        private void CargarReporte()
        {
            List<AsistentesModel> asistentes = asistenteController.ObtenerAsistentes();

            foreach (var asistente in asistentes)
            {
                Console.WriteLine("Holaa:" + asistente.Nombre);
            }

            ReportDataSource rds = new ReportDataSource("DataSet1", asistentes);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}
