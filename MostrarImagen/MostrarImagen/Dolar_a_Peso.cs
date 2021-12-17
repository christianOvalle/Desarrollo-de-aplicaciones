using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarImagen
{
    public partial class Dolar_a_Peso : Form
    {
        public Dolar_a_Peso()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "")
            {

                MessageBox.Show("Debe ingresar una cantidad");

            }

            else
            {
                int v1 = 0;
                int.TryParse(this.textBox1.Text, out v1);
                float resultado = v1 / 56.12f;
                this.textBox3.Text = resultado.ToString();

            }

        }
    }
}
