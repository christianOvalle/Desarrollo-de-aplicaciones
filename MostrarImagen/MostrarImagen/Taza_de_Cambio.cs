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
    public partial class Taza_de_Cambio : Form
    {
        public Taza_de_Cambio()
        {
            InitializeComponent();
        }

        private void dolarAPesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peso_A_Dolar peso_A_Dolar = new Peso_A_Dolar();

            peso_A_Dolar.ShowDialog();

            
        }

        private void pesoADolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dolar_a_Peso dolar_A_Peso = new Dolar_a_Peso();

            dolar_A_Peso.ShowDialog();
        }
    }
}
