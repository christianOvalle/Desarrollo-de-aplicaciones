using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Class1 : Form
    {

        private Button boton1, boton2;


        public Class1() {

            this.Size = new System.Drawing.Size(1000, 400);
            this.Text = "Prueba de cuadro";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.boton1 = new Button();
            this.boton1.Text = "Temor";
            this.boton1.SetBounds(0, 0, 50, 50);

            this.boton2 = new Button();
            this.boton2.Text = "color";
            this.boton2.SetBounds(70, 0, 50, 50);

            this.Controls.Add(boton1);
            this.Controls.Add(boton2);

            this.boton1.Click += Boton1_Click;
            this.boton2.Click += Boton2_Click;

        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");
        }


        private void Boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado boton 2");
        }
    }
}
