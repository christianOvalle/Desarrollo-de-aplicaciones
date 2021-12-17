using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar Imagen";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {


                MessageBox.Show(openFileDialog.FileName);

                Image image = Image.FromFile(openFileDialog.FileName);
                this.pictureBox1.Image = image;


            }

             





        }
    }
}
