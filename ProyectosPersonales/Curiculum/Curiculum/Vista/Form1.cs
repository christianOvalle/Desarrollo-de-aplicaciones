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
        Modelo.CurriculumEntities1 CurriculumEntities = new Modelo.CurriculumEntities1();
        public Form1()
        {
            InitializeComponent();
        }
        Modelo.Formacion_Y_estudios formacion_Y_Estudios = new Modelo.Formacion_Y_estudios();
        Modelo.DatosPersonales datosPersonales = new Modelo.DatosPersonales();
        Modelo.ExperienciaLaboral experienciaLaboral = new Modelo.ExperienciaLaboral();
        Modelo.Fotos fotos = new Modelo.Fotos();

      



        public void ComprobacionDeCampos() {


            string Telefono = this.textBox6.Text;
            string TelefonoMovil = this.textBox7.Text;
            string Cedula = this.textBox2.Text;
            string Direccion = this.textBox4.Text;
            string Apellidos = this.textBox1.Text;
            string Nombres = this.textBox9.Text;

      

            if (Telefono == "" || TelefonoMovil == "" || Apellidos == "" || Cedula == "" || Nombres == "")
            {
                MessageBox.Show("Faltan Campos por llenar en (Datos Personales)");
                this.textBox6.BackColor = Color.Red;
                
            }


            else if (radioButton1.Checked == false & radioButton2.Checked == false)
            {
                MessageBox.Show("Debe Marcar una de las opciones en (titulacion)");
            }


            else if (radioButton2.Checked & this.textBox12.Text == "") {

                MessageBox.Show("Especifique la carrera realizada o en proceso");
            }


            else if (radioButton4.Checked & this.textBox13.Text == "") {

                MessageBox.Show("Especifique el idioma");
            }

            else if (radioButton3.Checked == false & radioButton4.Checked == false)
            {

                MessageBox.Show("Debe Marcar una de las opciones en (Idiomas)");
            }

            else {


                DatosPersonales();
                FormacionYestudios();
                ExperienciaProfesional();


                CurriculumEntities.DatosPersonales.Add(datosPersonales);
                CurriculumEntities.Formacion_Y_estudios.Add(formacion_Y_Estudios);
                CurriculumEntities.ExperienciaLaboral.Add(experienciaLaboral);
                CurriculumEntities.SaveChanges();

                MessageBox.Show("Se ingreso Correctamente");



            }

        }

        public void DatosPersonales()
        {

            string Telefono = this.textBox6.Text;
            string TelefonoMovil = this.textBox7.Text;
            string Cedula = this.textBox2.Text;
            string Direccion = this.textBox4.Text;
            string Apellidos = this.textBox1.Text;
            string Fecha_de_nacimiento = this.textBox3.Text;
            string Localidad = this.textBox5.Text;
            string E_Mail = this.textBox8.Text;
            string Lugar = this.textBox10.Text;
            string Provincia = this.textBox11.Text;
            string Nombres = this.textBox9.Text;

            datosPersonales.Nombres = Nombres;
            datosPersonales.Apellidos = Apellidos;
            datosPersonales.Telefono = Telefono;
            datosPersonales.TelefonoCelular = TelefonoMovil;
            datosPersonales.Provincia = Provincia;
            datosPersonales.LugarDeNacimineto = Fecha_de_nacimiento;
            datosPersonales.Email = E_Mail;
            datosPersonales.LugarDeNacimineto = Lugar;
            datosPersonales.Localidad = Localidad;
            datosPersonales.Cedula = Cedula;
            datosPersonales.Direccion = Direccion;
            datosPersonales.FechaDeNacimiento = Fecha_de_nacimiento;

        }


        public void FormacionYestudios() {

            bool TieneTitulo = this.radioButton2.Checked;
            bool DominaIdiomas = this.radioButton4.Checked;
            bool NoTieneTitulos = this.radioButton1.Checked;
            bool NoDominaIdiomas = this.radioButton3.Checked;
            string especifiqueTitulo = this.textBox12.Text;
            string especifiqueIdiomas = this.textBox13.Text;
            string Cursosrealizados = this.textBox15.Text;
            string datosextras = this.textBox14.Text;

            if (TieneTitulo == true)
            {

                formacion_Y_Estudios.TitulosUniversitarios = "Si";

            }

            else if (NoTieneTitulos == true) {

                formacion_Y_Estudios.TitulosUniversitarios = "No";
            
            }

            if (DominaIdiomas == true)
            {

                formacion_Y_Estudios.Idiomas = "SI";

            }
            else if (NoDominaIdiomas == true) {

                formacion_Y_Estudios.Idiomas = "no";
            
            
            }


            formacion_Y_Estudios.CualCarrera = especifiqueTitulo;
            formacion_Y_Estudios.CualesIdiomas = especifiqueIdiomas;
            formacion_Y_Estudios.CursosRealizados = Cursosrealizados;
            formacion_Y_Estudios.ConocimientosInformaticos = datosextras;

        }

        public void ExperienciaProfesional() {

            string Empresa = this.textBox16.Text;
            string Puesto = this.textBox17.Text;
            string F_Entrada = this.textBox18.Text;
            string F_Salida = this.textBox19.Text;
            string datosComplemetarios = this.textBox20.Text;

            experienciaLaboral.Empresa = Empresa;
            experienciaLaboral.Puesto = Puesto;
            experienciaLaboral.FechaDeEntrada = F_Entrada;
            experienciaLaboral.FechaDeSalida = F_Salida;
            experienciaLaboral.DatosComplementarios = datosComplemetarios;

           
        }           


        private void button2_Click(object sender, EventArgs e)
            {

            ComprobacionDeCampos();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            DialogResult result = img.ShowDialog();

            if (result == DialogResult.OK) {

                pictureBox1.Image = Image.FromFile(img.FileName);

                
            
            }
            
         

        }
    }
    }
