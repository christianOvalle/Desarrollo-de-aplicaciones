using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preguntas
{
    public partial class Form1 : Form

    {

        List<preguntas> Preguntas = new List<preguntas>();



        public Form1()
        {
            InitializeComponent();

            Preguntas.Add(new preguntas { pregunta = "1", RespuestaCorrecta = true });
            Preguntas.Add(new preguntas { pregunta = "2", RespuestaCorrecta = true });

            double Re = (2 * 100);
            double Re2 = Re / 2;
            Console.WriteLine(Re);
            Console.WriteLine(Re2);
            int porcentaje = (int)Re2;
            this.progressBar1.Value = porcentaje;

        }


        public class preguntas
        {

            public string pregunta { set; get; }
            public bool RespuestaCorrecta { set; get; }
            public bool RespuestaUsuario { set; get; }
            public bool esCorrectaLaRespuesta()
            {

                bool ver = false;

                if (RespuestaCorrecta == RespuestaUsuario)
                {

                    MessageBox.Show("Respuesta Correcta");
                    ver = true;
                }

                 if (RespuestaCorrecta == RespuestaUsuario)
                {

                    MessageBox.Show("Respuesta Incorrecta");
                    ver = false;
                }

                else {

                    MessageBox.Show("Elegir una opcion");
                
                } 
                return ver;
            }

                        
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                Preguntas[0].RespuestaUsuario = true;
                          
            }
            else if (radioButton2.Checked) {
                Preguntas[0].RespuestaUsuario = false;
            
            }
            Preguntas[0].esCorrectaLaRespuesta();

            this.tabControl1.SelectedIndex = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                Preguntas[1].RespuestaUsuario = true;

            }
            else if (radioButton2.Checked)
            {
                Preguntas[1].RespuestaUsuario = false;

            }
            Preguntas[1].esCorrectaLaRespuesta();

            this.tabControl1.SelectedIndex = 2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }
    }
    }
    














