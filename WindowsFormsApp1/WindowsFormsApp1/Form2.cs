using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar();
            correcto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int.TryParse(this.textBox1.Text, out valor1);
            int valor2 = 0;
            int.TryParse(this.textBox2.Text, out valor2);
            int resultado = valor1 - valor2;
            this.textBox3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int.TryParse(this.textBox1.Text, out valor1);
            int valor2 = 0;
            int.TryParse(this.textBox2.Text, out valor2);
            int resultado = valor1 * valor2;
            this.textBox3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int.TryParse(this.textBox1.Text, out valor1);
            int valor2 = 0;
            int.TryParse(this.textBox2.Text, out valor2);
            int resultado = valor1 / valor2;
            this.textBox3.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
        }

        private void validar() {

            if (this.textBox1.Text == "")
            {

                MessageBox.Show("Añadir un valor al campo 1");
                this.label3.BackColor = Color.Red;
                this.label3.ForeColor = Color.White;
                this.label3.Text = "Ingrese un texto";
            }

           

            else if (this.textBox2.Text == "")
            {

                MessageBox.Show("Añadir un valor al campo 2");

            }
            else {
                int valor1 = 0;
                int.TryParse(this.textBox1.Text, out valor1);
                int valor2 = 0;
                int.TryParse(this.textBox2.Text, out valor2);
                int resultado = valor1 + valor2;
                this.textBox3.Text = resultado.ToString();

            }
        
        private void correcto() { 
         if (this.textBox1.Text != "") { 
            
                this.label3.BackColor = Color.Green;
                //this.label3.ForeColor = Color.White;
            }   
            
            
         }
        
        }
    }
}
