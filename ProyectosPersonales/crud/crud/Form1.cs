using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {

         crud_pruebaEntities crud_ = new crud_pruebaEntities();

        public Form1()
        {
            InitializeComponent();
            setdata();
        }

        public void setdata() { 
        
        this.dataGridView1.DataSource = crud_.persona.ToList();
        
        }
        public void insert() {

            persona persona = new persona();

            persona.nombre = textBox1.Text;
            persona.apellido = textBox2.Text;
            persona.cedula = textBox3.Text;
            persona.correo = textBox4.Text;
            persona.edad = (int?)decimal.Parse(numericUpDown1.Value.ToString());

            MessageBox.Show("Registro Insertado");

            crud_.persona.Add(persona);
            crud_.SaveChanges();
            setdata();

        }

        public void delete() {

            int id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            var persona1 = crud_.persona.Find(id);
            MessageBox.Show("Registro Borrado");
            crud_.persona.Remove(persona1);
            crud_.SaveChanges();
            setdata();

        }
        public void edit() {
            int id = int.Parse(this.dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            var perso = crud_.persona.Find(id);
            perso.nombre = this.textBox1.Text;
            perso.apellido = this.textBox2.Text;
            perso.cedula = this.textBox3.Text;
            perso.correo = this.textBox4.Text;
            perso.edad = (int?)decimal.Parse(this.numericUpDown1.Value.ToString());
            

            crud_.Entry(perso).State = System.Data.Entity.EntityState.Modified;
            crud_.SaveChanges();
            MessageBox.Show("Registro Editado");
            setdata();
           

        }

        private void llenarCampos(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id"].Value);
            var perso = crud_.persona.Find(id);
            this.textBox1.Text = perso.nombre;
            this.textBox2.Text = perso.apellido;
            this.textBox3.Text = perso.cedula;   
            this.textBox4.Text = perso.correo;
            this.numericUpDown1.Text = perso.edad.ToString();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            insert();
        }


        private void buttonborrar_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            edit();
        }
    }
}
