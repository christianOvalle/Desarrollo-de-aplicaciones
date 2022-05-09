using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Vistas
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mecanico mecanico = new Mecanico();
            mecanico.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Piezas piezas = new Piezas();
            piezas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsignacionMec asignar = new AsignacionMec();
            asignar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            detalleForm detalle = new detalleForm();
            detalle.ShowDialog();
        }
    }
}
