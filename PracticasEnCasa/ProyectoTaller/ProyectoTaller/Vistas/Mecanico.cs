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
    public partial class Mecanico : Form
    {

        Conexion.db_taller_infotepEntities db_TallerEntities = new Conexion.db_taller_infotepEntities();

        public Mecanico()
        {
            InitializeComponent();
            SetDataGrid();
        }


        public void SetDataGrid()
        {

            var datosM = (from mec in db_TallerEntities.Mecanicos
                          join veh in db_TallerEntities.Vehiculos
                          on mec.id_vehiculo equals veh.id_vehiculo
                          select new
                          {
                              mec.id_mecanico,
                              mec.nombre,
                              mec.apellido,
                              mec.cedula,
                              mec.fecha_nacimiento,
                              mec.estatus,                             
                              veh.matricula,
                              mec.id_vehiculo
                         }).ToList();
            MecanicodataGridView.DataSource = datosM;
           
        }

        public void LimpiarCampos() { 
        
        this.textBoxNombre.Clear();
        this.textBoxApellido.Clear();
        this.textBoxCedula.Clear();
        this.textBoxFecha.Clear();       
        
        }

        public void TomarDatos()
        {

            var mecanicoA = new Conexion.Mecanicos();
            var veh = new Conexion.Vehiculos();

            mecanicoA.nombre = this.textBoxNombre.Text;
            mecanicoA.apellido = this.textBoxApellido.Text;
            mecanicoA.cedula = this.textBoxCedula.Text;
            mecanicoA.fecha_nacimiento = this.textBoxFecha.Text;
            veh.matricula = "";
            if (radioButtonD.Checked) {
                mecanicoA.estatus = false;
            }
            else if (radioButtonN.Checked) {

                mecanicoA.estatus = true;
            }
            db_TallerEntities.Vehiculos.Add(veh);
            db_TallerEntities.Mecanicos.Add(mecanicoA);
            db_TallerEntities.SaveChanges();
            SetDataGrid();

        }

        public void Borrar()
        {

            int ID = Convert.ToInt32(MecanicodataGridView.CurrentRow.Cells["id_mecanico"].Value.ToString());
            var mecanicoB = db_TallerEntities.Mecanicos.Find(ID);
            db_TallerEntities.Mecanicos.Remove(mecanicoB);
            db_TallerEntities.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();

        }

        public void Editar()
        {

           
            int ID = Convert.ToInt32(MecanicodataGridView.CurrentRow.Cells["id_mecanico"].Value.ToString());
            var mecanicoE = db_TallerEntities.Mecanicos.Find(ID);

            mecanicoE.nombre = this.textBoxNombre.Text;
            mecanicoE.apellido = this.textBoxApellido.Text;
            mecanicoE.cedula = this.textBoxCedula.Text;
            mecanicoE.fecha_nacimiento = this.textBoxFecha.Text;
            if (radioButtonD.Checked)
            {
                mecanicoE.estatus = false;
            }
            else if (radioButtonN.Checked)
            {

                mecanicoE.estatus = true;
            }

            db_TallerEntities.Entry(mecanicoE).State = System.Data.Entity.EntityState.Modified;
            db_TallerEntities.SaveChanges();

            MessageBox.Show("Se a modificado");

            SetDataGrid();


        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            TomarDatos();
            SetDataGrid();
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void buttondel_Click(object sender, EventArgs e)
        {

            Borrar();

        }


        private void MecanicodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.MecanicodataGridView.CurrentRow.Cells["id_mecanico"].Value);
            var valor = db_TallerEntities.Mecanicos.Find(id);

            this.textBoxNombre.Text = valor.nombre;
            this.textBoxApellido.Text = valor.apellido;
            this.textBoxCedula.Text = valor.cedula;
            this.textBoxFecha.Text = valor.fecha_nacimiento;
        }

    }
}

