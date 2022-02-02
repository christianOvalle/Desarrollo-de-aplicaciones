using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conector
{
    public partial class Form1 : Form
    {

        coneccion.db_probandoEntities db_ = new coneccion.db_probandoEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = db_.persona.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = db_.persona.ToList();
            this.comboBox1.DisplayMember = "cedula";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.DataSource = db_.persona.ToList();
            this.listBox1.DisplayMember = "nombre";
            this.listBox1.ValueMember = "id";

        }
    }
}
