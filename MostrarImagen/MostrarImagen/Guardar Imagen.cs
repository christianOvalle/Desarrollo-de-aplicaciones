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
    public partial class Guardar_Imagen : Form
    {
        public Guardar_Imagen()
        {
            InitializeComponent();
            MostraImagen();
        }

        public void MostraImagen()
        {

            string ruta = @"C:\Users\infotep\Downloads\MAYI.jpg";
            Image image = Image.FromFile(ruta);
            this.cuadro.Image = image;


        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar imagen";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Image image = this.cuadro.Image;
                image.Save(saveFileDialog.FileName);
            }
        }
    }
}

