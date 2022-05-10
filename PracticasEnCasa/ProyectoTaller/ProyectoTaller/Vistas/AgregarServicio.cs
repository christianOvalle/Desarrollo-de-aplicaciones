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
    public partial class AgregarServicio : Form
    {
        Conexion.db_taller_infotepEntities db_Taller_Infotep = new Conexion.db_taller_infotepEntities();


        public AgregarServicio()
        {
            InitializeComponent();
            SetDataGrid();


        }

        public void SetDataGrid()
        {

            var datosServ = (from serv in db_Taller_Infotep.Servicios
                          select new
                          {
                              serv.id_servicio,
                              serv.tipo_servicio,
                              serv.costo
                              
                          }).ToList();

            dataGridViewServicios.DataSource = datosServ;
        }
        public void limpiarCampos()
        {
            numericid.Value = 0;
            textBoxTiposerv.Clear();
            numericCosto.Value = 0;
           
        }

        public void TomarDatos()
        {

            var serv = new Conexion.Servicios();

            
            serv.tipo_servicio = textBoxTiposerv.Text;
            serv.costo = int.Parse(numericCosto.Value.ToString());

            db_Taller_Infotep.Servicios.Add(serv);
            db_Taller_Infotep.SaveChanges();
            

        }

        private void buttonaddserv_Click(object sender, EventArgs e)
        {
            TomarDatos();
            SetDataGrid();
            limpiarCampos();
        }

        private void buttondeleteserv_Click(object sender, EventArgs e)
        {

           Servicios servB = db_Taller_Infotep.Servicios.Find(numericid.Value);
           db_Taller_Infotep.Servicios.Remove(servB);
           db_Taller_Infotep.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();
            limpiarCampos();
        }



        private void buttoneditserv_Click (object sender, EventArgs e)
        {

            Servicios servE= db_Taller_Infotep.Servicios.Find(numericid.Value);
            servE.tipo_servicio = this.textBoxTiposerv.Text;
            servE.costo = Convert.ToInt32(this.numericCosto.Text);
           

            db_Taller_Infotep.Entry(servE).State = System.Data.Entity.EntityState.Modified;
            db_Taller_Infotep.SaveChanges();

            MessageBox.Show("Se a modificado");

            limpiarCampos();
            SetDataGrid();

        }
   
        private void llenar(object sender, DataGridViewCellEventArgs e)
        {
            numericid.Value = decimal.Parse(dataGridViewServicios.CurrentRow.Cells[0].Value.ToString());
            textBoxTiposerv.Text = dataGridViewServicios.CurrentRow.Cells[1].Value.ToString();
            numericCosto.Value = int.Parse(dataGridViewServicios.CurrentRow.Cells[2].Value.ToString());
        }

       
    }
}
