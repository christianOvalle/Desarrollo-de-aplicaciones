using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaConArreglos
{
    public partial class Form1 : Form
    {

        private Alumno[] alumno2;

        public Form1()
        {
            InitializeComponent();
            this.alumno2 = new Alumno[20];
            this.llenar();
        }

        public void llenar() {
            for (int i = 0; i < alumno2.Length; i++) {

                this.alumno2[i] = new Alumno();

            }
        
        
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < alumno2.Length; i++) {

                this.dataGridView1.Rows.Add(
                  this.alumno2[i].nombre,
                  this.alumno2[i].matricula,
                  this.alumno2[i].nota,
                  i

                 );
            
            }

        }

        private void ingresarAlumnos() {
            int index = int.Parse(this.textBox4.Text);
            this.alumno2[index] = new Alumno(this.textBox1.Text, this.textBox2.Text, float.Parse(this.textBox3.Text));
            MessageBox.Show("Se agrego correctamente");
        
        
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ingresarAlumnos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
