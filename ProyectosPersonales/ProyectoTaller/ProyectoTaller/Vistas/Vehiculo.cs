using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller.Vistas
{
    public partial class Vehiculo : Form
    {
        public Vehiculo()
        {
            InitializeComponent();
            LlenarGrid();
        }

        Cvehiculo Cvehiculo = new Cvehiculo();
        Conexion.Vehiculos Vehi = new Conexion.Vehiculos();
        int id;

        private void LlenarGrid() {

            var leer = Cvehiculo.Leer();
            VehiculodataGridView.DataSource = leer.ToList();
        }


        private void Vehiculo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        public void limpiar() {

            id = 0;
            this.textBoxColor.Text = "";
            this.textBoxMarca.Text = "";
            this.textBoxMatricula.Text = "";
            this.textBoxModelo.Text = "";
            LlenarGrid();
        }

        public void Guardar() {

            Conexion.Clientes clientes = new Conexion.Clientes();

            Vehi.id_vehiculo = id;
            Vehi.marca = this.textBoxMarca.Text;
            Vehi.matricula = this.textBoxMatricula.Text;
            Vehi.modelo = this.textBoxModelo.Text;
            Vehi.color = this.textBoxColor.Text;
            
        
        }

        private void Agregarbuttonv_Click(object sender, EventArgs e)
        {
            Guardar();
            Cvehiculo.agregar(Vehi);
            limpiar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

                Guardar();
                Cvehiculo.actualizar(Vehi);
                limpiar();
            }
        }

        private void VehiculodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

                
                Cvehiculo.borrar(id);
                limpiar();
            }

        }

        private void VehiculodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            id = Convert.ToInt32(VehiculodataGridView.CurrentRow.Cells["id_vehiculo"].Value.ToString());
            textBoxMatricula.Text = VehiculodataGridView.CurrentRow.Cells["matricula"].Value.ToString();
            textBoxModelo.Text = VehiculodataGridView.CurrentRow.Cells["modelo"].Value.ToString();
            textBoxColor.Text = VehiculodataGridView.CurrentRow.Cells["color"].Value.ToString();
            textBoxMarca.Text = VehiculodataGridView.CurrentRow.Cells["marca"].Value.ToString();
        }
    }
}
