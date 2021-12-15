using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudLista
{
    public partial class Form1 : Form
    {

        List<Carro> carros = new List<Carro>();

        public Form1()
        {
            InitializeComponent();
            llenarDatos();
            MostrarDatos();
        }

        public void llenarDatos() {

            this.carros.Add(new Carro("jorge", "cabrera", 34));
            this.carros.Add(new Carro("Miguel", "Ferrer", 20));
            this.carros.Add(new Carro("Tomas", "Lopez", 18));



        }

        public void MostrarDatos (){
        this.dataGridView1.DataSource = carros.ToList();




}

       



}

    }

