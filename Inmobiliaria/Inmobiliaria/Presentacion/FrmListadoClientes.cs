
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inmobiliaria.Models;
using Microsoft.Reporting.WinForms;

namespace Inmobiliaria.Presentacion
{
    
    public partial class FrmListadoClientes : Form
    {
        private readonly ReportViewer reporte;
        public FrmListadoClientes()
        {
            InitializeComponent();
            //instanciamos un visor de reportes
            reporte = new ReportViewer();
            //hacemos que ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            // abrimos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"..\..\..\Reportes\ReporteClientes.rdlc", FileMode.Open);

            //asignamos el archivo a la propiedad LocalReport del objeto RepotViewer
            reporte.LocalReport.LoadReportDefinition(fs);

            //buscamos los datos que va a graficar el reporte
            using var db = new InmobiliariaContext();
            var cliente= db.Cliente.ToList();

            //asignamos los datos a la propiedad DataSource de Local Report utilizando un objeto de tipo ReportDataSource
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DataSetListadoClientes", cliente));

            reporte.RefreshReport();
        }
    }
}
