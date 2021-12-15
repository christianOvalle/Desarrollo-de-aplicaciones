using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uso_de_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> notas = new List<int>();
        
        



        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.notas.Add(int.Parse(this.textBox1.Text));
            
            
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            int promedio = 0;
            this.textBox1.Text = "";
            foreach (var item in notas) {
                promedio += item;
                this.textBox1.Text = item.ToString() + "\n";


            }

            var Promedio = (promedio / notas.Count).ToString();
            MessageBox.Show(Promedio);
            this.textBox2.Text = Promedio;


        }
    }
}
