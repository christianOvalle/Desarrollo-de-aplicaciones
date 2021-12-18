using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validarsum();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validarres();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Validardiv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Validarmulti();
        }

        private void Validarsum()
        {

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ingrese primer valor");
                this.label3.BackColor = Color.Red;

            }
          

            else if (this.textBox2.Text == "")
            {


                MessageBox.Show("Ingrese Segundo valor");
                this.label4.BackColor = Color.Red;

            }

            else
            {
                valoresValidos();
                int v1 = 0;
                int.TryParse(textBox1.Text, out v1);
                int v2 = 0;
                int.TryParse((string)textBox2.Text, out v2);
                int resultado = v1 + v2;
                this.textBox3.Text = resultado.ToString();
            }

        }

        private void Validarres()
        {

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ingrese primer valor");
                this.label3.BackColor = Color.Red;

            }


            else if (this.textBox2.Text == "")
            {


                MessageBox.Show("Ingrese Segundo valor");
                this.label4.BackColor = Color.Red;

            }
            else
            {
                valoresValidos();
                int v1 = 0;
                int.TryParse(textBox1.Text, out v1);
                int v2 = 0;
                int.TryParse((string)textBox2.Text, out v2);
                int resultado = v1 - v2;
                this.textBox3.Text = resultado.ToString();
            }



        }

        private void Validarmulti()
        {

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ingrese primer valor");
                this.label3.BackColor = Color.Red;

            }


            else if (this.textBox2.Text == "")
            {


                MessageBox.Show("Ingrese Segundo valor");
                this.label4.BackColor = Color.Red;

            }
            else
            {
                valoresValidos();
                int v1 = 0;
                int.TryParse(textBox1.Text, out v1);
                int v2 = 0;
                int.TryParse((string)textBox2.Text, out v2);
                int resultado = v1 * v2;
                this.textBox3.Text = resultado.ToString();
            }



        }

        private void Validardiv()
        {

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Ingrese primer valor");
                this.label3.BackColor = Color.Red;

            }


            else if (this.textBox2.Text == "")
            {


                MessageBox.Show("Ingrese Segundo valor");
                this.label4.BackColor = Color.Red;

            }
            else
            {
                valoresValidos();
                int v1 = 0;
                int.TryParse(textBox1.Text, out v1);
                int v2 = 0;
                int.TryParse((string)textBox2.Text, out v2);
                int resultado = v1 / v2;
                this.textBox3.Text = resultado.ToString();
            }



        }


        private void valoresValidos()
        {

            if (this.textBox1.Text != "")
            {

                this.label3.BackColor = Color.Green;

            }
            if (this.textBox2.Text != "")
            {
                this.label4.BackColor = Color.Green;           
            
            }
        }
    }
}
    
    

