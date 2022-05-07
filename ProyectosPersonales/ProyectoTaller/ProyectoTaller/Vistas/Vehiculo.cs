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
        Conexion.db_taller_infotepEntities db_Taller = new Conexion.db_taller_infotepEntities();

        public Vehiculo()
        {
            InitializeComponent();
            SetDataGrid();

        }

        public void SetDataGrid()
        {

            VehiculodataGridView.DataSource = db_Taller.Vehiculos.ToList();
        }


        public void TomarDatos()
        {

            var vehiculoA = new Conexion.Vehiculos();

            vehiculoA.matricula = this.textBoxMatricula.Text;
            vehiculoA.modelo = this.textBoxModelo.Text;
            vehiculoA.color = this.textBoxColor.Text;
            



            db_Taller.Vehiculos.Add(vehiculoA);
            db_Taller.SaveChanges();

        }

        private void Agregarbuttonv_Click_1(object sender, EventArgs e)
        {
            TomarDatos();
            SetDataGrid();
        }

        private void Borrabuttonv_Click_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(VehiculodataGridView.CurrentRow.Cells["id_vehiculo"].Value.ToString());
            var vehiculoB = db_Taller.Vehiculos.Find(ID);
            db_Taller.Vehiculos.Remove(vehiculoB);
            db_Taller.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();
        
    
}
     
        private void Modificarbuttonv_Click_1(object sender, EventArgs e)
        {

            String matricula= this.textBoxMatricula.Text;
            string modelo = this.textBoxModelo.Text;
            string color = this.textBoxColor.Text;
                      
            int ID = Convert.ToInt32(VehiculodataGridView.CurrentRow.Cells["id_vehiculo"].Value.ToString());


            var vehiculoE = db_Taller.Vehiculos.Find(ID);

            vehiculoE.matricula = matricula;
            vehiculoE.modelo = modelo;
            vehiculoE.color = color;
           
                       
            db_Taller.Entry(vehiculoE).State = System.Data.Entity.EntityState.Modified;
            db_Taller.SaveChanges();

            MessageBox.Show("Se a modificado");

            SetDataGrid();

        }
        
        private void VehiculodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(this.VehiculodataGridView.CurrentRow.Cells["id_vehiculo"].Value);
            var valor = db_Taller.Vehiculos.Find(id);

            this.textBoxMatricula.Text = valor.matricula;
            this.textBoxMatricula.Text = valor.modelo;
            this.textBoxColor.Text = valor.color;
                     
        }
        
       

    }
}

