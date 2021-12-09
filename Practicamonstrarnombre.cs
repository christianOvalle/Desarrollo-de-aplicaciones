using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public class Ventanas : Form1
    {
        private Button boton1, boton2, boton3;
        private Label lb1;
        private TextBox texbox;


        public Ventanas()
        {



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


            this.lb1 = new Label();
            this.lb1.Text = "Nombre";
            this.lb1.SetBounds(0, 100, 60, 80);
            this.Controls.Add(lb1);

            this.texbox = new TextBox();
            this.texbox.SetBounds(60, 97, 60, 80);
            this.Controls.Add(this.texbox);

            this.boton3 = new Button();
            this.boton3.Text = "Mostrar el nombre";
            this.boton3.SetBounds(67, 135, 50, 50);
            this.Controls.Add(this.boton3);

            this.boton3.Click += Boton3_Click;   

        }

        private void Boton3_Click(object sender, EventArgs e)
        {
             MessageBox.Show(texbox.Text);
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