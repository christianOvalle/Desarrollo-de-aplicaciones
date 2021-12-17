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
    public partial class MostrarHorascs : Form
    {
        public MostrarHorascs()
        {
            InitializeComponent();
          
           
        }

        public void mostraHora()
        {

            this.label1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


        }

        private void MostrarHorascs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mostraHora();
        }
    }
}
