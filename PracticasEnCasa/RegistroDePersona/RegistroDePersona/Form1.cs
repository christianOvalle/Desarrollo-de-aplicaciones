using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegistroDePersona
{
    public partial class Form1 : Form
    {

        PruebaEnCasaEntities PruebaEnCasaEntities = new PruebaEnCasaEntities();
        persona persona = new persona();
        DateTimePicker DateTimePicker = new DateTimePicker();

        public Form1()
        {
            InitializeComponent();
            MostrarDatos();

        }

        public void TomadorDeDataos()
        {

            persona.Nombre = this.textBox1.Text;
            persona.Apellido = this.textBox2.Text;
            persona.Cedula = this.textBox3.Text;
            persona.Edad = Convert.ToInt32(this.textBox4.Text);
            persona.fechaIngreso = Convert.ToDateTime(DateTimePicker.Value.ToString("G"));


        }

        public void LimpiarEspacios()
        {

            persona persona = new persona();
            this.textBox1.Text = persona.Nombre;
            this.textBox2.Text = persona.Apellido;
            this.textBox3.Text = persona.Cedula;
            this.textBox4.Text = persona.Edad.ToString();


        }

        public void MostrarDatos()
        {

            this.dataGridView1.DataSource = PruebaEnCasaEntities.persona.ToList();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            TomadorDeDataos();
            PruebaEnCasaEntities.persona.Add(persona);
            PruebaEnCasaEntities.SaveChanges();

            MessageBox.Show("Se Agrego");
            LimpiarEspacios();
            MostrarDatos();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            persona persona = new persona();
            TomadorDeDataos();
            this.dataGridView1.DataSource = PruebaEnCasaEntities.persona;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.textBox5.Text);
            persona persona = PruebaEnCasaEntities.persona.Find(ID);
            PruebaEnCasaEntities.persona.Remove(persona);
            PruebaEnCasaEntities.SaveChanges();

            MessageBox.Show("Se Elimino");
            MostrarDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TomadorDeDataos();
            int ID = int.Parse(this.textBox5.Text);
            persona persona = PruebaEnCasaEntities.persona.Find(ID);

            PruebaEnCasaEntities.Entry(persona).State = System.Data.Entity.EntityState.Modified;
            PruebaEnCasaEntities.SaveChanges();

            MostrarDatos();

        }
    }
}