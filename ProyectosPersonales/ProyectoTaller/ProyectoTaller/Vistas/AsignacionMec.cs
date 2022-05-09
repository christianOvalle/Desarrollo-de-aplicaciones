using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller.Conexion;

namespace ProyectoTaller.Vistas
{
    public partial class AsignacionMec : Form
    {
        db_taller_infotepEntities dbTaller = new db_taller_infotepEntities();

        public AsignacionMec()
        {
            InitializeComponent();
        }

        public void mostrar()
        {
            dataGridView1.DataSource = dbTaller.Mecanicos.ToList();
        }

        public void llenarCombo()
        {
            var consulta = (from veh in dbTaller.Vehiculos
                           select new {
                               veh.id_vehiculo,
                               veh.matricula,                               
                           }).ToList();

            matriculaVehiculo.DataSource = consulta;
            matriculaVehiculo.DisplayMember = "matricula";
            matriculaVehiculo.ValueMember = "id_vehiculo";
            
        }

        private void AsignacionMec_Load(object sender, EventArgs e)
        {
            mostrar();
            llenarCombo();
        }

        private void rellenarCampos(object sender, DataGridViewCellEventArgs e)
        {
            idCliente.Value = decimal.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NombretextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ApellidotextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CedulatextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Mecanicos mec = dbTaller.Mecanicos.Find(idCliente.Value);
            mec.id_vehiculo = int.Parse(matriculaVehiculo.SelectedValue.ToString());
            dbTaller.SaveChanges();
        }
    }
}
