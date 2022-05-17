using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTranslogic.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CompaniasRegistros registros = new CompaniasRegistros();
            registros.ShowDialog();
        }
    }
}
