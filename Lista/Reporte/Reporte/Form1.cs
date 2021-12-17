using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto(1,"Leche Milex",4, 1, 567.12));

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("dataset", productos);





            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\infotep\Documents\Diagrama cristian\PracticasPOO\practicaspoo2021\Lista\Reporte\Reporte\";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
