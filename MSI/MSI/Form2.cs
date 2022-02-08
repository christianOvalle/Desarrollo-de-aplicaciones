using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSI
{
    public partial class Form2 : Form
    {

        private static Form2 formulario = null;

        public Form2()
        {
            InitializeComponent();
        }

        public static Form2 obtenerformulario2() {

            if (formulario == null ) {

                formulario = new Form2();
                     
            }
            formulario.Activate();
            return formulario;
        
        
        
        }

       
    }
}
