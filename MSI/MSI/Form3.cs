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
    public partial class Form3 : Form
    {

        private static Form3 formulario1 = null;

        public Form3()
        {
            InitializeComponent();
        }


        public static Form3 obtenerformulario2()
        {

            if (formulario1 == null)
            {

                formulario1 = new Form3();

            }
            formulario1.Activate();
            return formulario1;

        }
    }
}