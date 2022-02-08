using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 articulo2 = Form2.obtenerformulario2();
            articulo2.Show();

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 articulo3 = new Form3();
            articulo3.MdiParent = null;
            articulo3.Show();

            
            articulo3 = Form3.obtenerformulario2();
            articulo3.Show();


        }
    }
}
