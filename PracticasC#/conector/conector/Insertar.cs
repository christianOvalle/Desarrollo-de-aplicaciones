using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conector
{
    public partial class Insertar : Form
    {

        coneccion.db_probandoEntities db_ProbandoEntities = new coneccion.db_probandoEntities();

        public Insertar()
        {
            InitializeComponent();
            mostrarDatos();
         

        }

        public void mostrarDatos() {

            this.dataGridView1.DataSource = db_ProbandoEntities.persona.ToList();
        
        
        }

        public void LimpiarDatos() {


            coneccion.persona personas = new coneccion.persona();
            this.textBox1.Text = personas.nombre;
            this.textBox2.Text = personas.apellido;
            this.textBox3.Text = personas.cedula;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nombre = this.textBox1.Text;
            string Apellido = this.textBox2.Text;
            string Cedula = this.textBox3.Text;

            coneccion.persona persona = new coneccion.persona();

            persona.nombre = Nombre;
            persona.apellido = Apellido;
            persona.cedula = Cedula;

            db_ProbandoEntities.persona.Add(persona);
            db_ProbandoEntities.SaveChanges();

            MessageBox.Show("Se ingreso correctamente");

            LimpiarDatos();
            mostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.textBox4.Text);
            coneccion.persona persona = db_ProbandoEntities.persona.Find(ID);
            db_ProbandoEntities.persona.Remove(persona);
            db_ProbandoEntities.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            mostrarDatos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Nombre = this.textBox1.Text;
            string Apellido = this.textBox2.Text;
            string Cedula = this.textBox3.Text;
            int ID = int.Parse(this.textBox4.Text);

            coneccion.persona persona = db_ProbandoEntities.persona.Find(ID);

            persona.nombre = Nombre;
            persona.apellido = Apellido;
            persona.cedula = Cedula;

            db_ProbandoEntities.Entry(persona).State = System.Data.Entity.EntityState.Modified;
            db_ProbandoEntities.SaveChanges();

            MessageBox.Show("Se a modificado");
            mostrarDatos();
        }

       

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            List<coneccion.persona> personas = db_ProbandoEntities.persona.Where(x => x.nombre.Contains(this.textBox5.Text)).ToList();
        }
    }
}
