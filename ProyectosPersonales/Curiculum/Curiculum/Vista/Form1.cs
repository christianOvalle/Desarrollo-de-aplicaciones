using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curiculum
{

    
    public partial class Form1 : Form
    {
        Modelo.CurriculumEntities CurriculumEntities = new Modelo.CurriculumEntities();
        public Form1()
        {
            InitializeComponent();
        }
       

        public void DatosObligatorios() {

         Modelo.DatosPersonales datosPersonales = new Modelo.DatosPersonales();

         string Telefono = this.textBox6.Text;
         string TelefonoMovil = this.textBox7.Text;
         string Apellidos = this.textBox1.Text;
         string Cedula = this.textBox2.Text;
         string Direccion = this.textBox4.Text;

            if (Telefono == "" || TelefonoMovil == "" || Apellidos == "" || Cedula == "" || Direccion == "")
            {

                MessageBox.Show("Debe llenar los campos restantes");

            }
            else {

                string Fecha_de_nacimiento = this.textBox3.Text;
                string Localidad = this.textBox5.Text;
                string E_Mail = this.textBox8.Text;
                string Lugar = this.textBox10.Text;
                string Provincia = this.textBox11.Text;

                datosPersonales.FechaDeNacimiento = Fecha_de_nacimiento;
                datosPersonales.Localidad = Localidad;
                datosPersonales.Email = E_Mail;
                datosPersonales.LugarDeNacimineto = Lugar;
                datosPersonales.Provincia = Provincia;
                datosPersonales.Telefono = 
                datosPersonales.TelefonoCelular = int.Parse(TelefonoMovil);
                datosPersonales.Apellidos =Apellidos;
                datosPersonales.Cedula = Cedula;
                datosPersonales.Direccion = Direccion;


                CurriculumEntities.DatosPersonales.Add(datosPersonales);
                CurriculumEntities.SaveChanges();

            }
        }

        public void Estudios() {

            Modelo.Formacion_Y_estudios formacion_Y_Estudios = new Modelo.Formacion_Y_estudios();

            if (radioButton1.Checked)
            {

                formacion_Y_Estudios.TitulosUniversitarios = "No tiene titulos";

            }
            else if (radioButton2.Checked) {

                formacion_Y_Estudios.TitulosUniversitarios = this.textBox12.Text;


            }

            else {

                MessageBox.Show("Debe marcar una las opciones");
            
            }


           

        }

        public void estudiar2() {
            Modelo.Formacion_Y_estudios formacion_Y_Estudios = new Modelo.Formacion_Y_estudios();
            if (radioButton3.Checked)
            {
                formacion_Y_Estudios.Idiomas = "No Domina Idiomas";
           }
            else if (radioButton4.Checked)
            {
               formacion_Y_Estudios.Idiomas = this.textBox13.Text;
            }

            else
            {

                MessageBox.Show("Debe marcar una de las opciones");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            DatosObligatorios();
            Estudios();
            estudiar2();
            
        }




    }
}
