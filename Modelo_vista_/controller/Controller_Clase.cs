using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo_vista_.controller
{
    public class Controller_Clase
    {

        private Form1 vista = null;

        public Controller_Clase(Form1 frm) {
            this.vista = frm;


        }

        public void Validaciones() {
            double resultado;
            if (this.vista.textBox1.Text == "" ) {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor en el campo 1");
                //resultado = double.Parse("");


            }
            else if (this.vista.textBox2.Text == "")
            {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor en el campo 2");
                //resultado = double.Parse(this.vista.textBox2.Text);
            }
            else {

                double v1 = double.Parse(this.vista.textBox1.Text);
                double v2 = double.Parse(this.vista.textBox2.Text);

                resultado = v1 + v2;
                this.vista.textBox3.Text = resultado.ToString();
                this.vista.listBox1.Items.Add(resultado);

            }

        
        
        
        
        
        }


       /* public void sumar() {

            double v1 = double.Parse(this.vista.textBox1.Text);
            double v2 = double.Parse(this.vista.textBox2.Text);

            double resultado = v1 + v2;
            this.vista.textBox3.Text =resultado.ToString();
        
        
        
        }*/

    }
}
