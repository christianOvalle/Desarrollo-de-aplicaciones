using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_vista_
{
    public partial class Form1 : Form
    {


        controller.Controller_Clase controller1;
      


        public Form1()
        {
            InitializeComponent();
            this.controller1 = new controller.Controller_Clase(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //controller1.sumar();
            controller1.Validaciones();
        }
    }
}
