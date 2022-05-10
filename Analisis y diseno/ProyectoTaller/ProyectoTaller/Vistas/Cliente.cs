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
    public partial class Cliente : Form
    {
        db_taller_infotepEntities  dbtaller = new db_taller_infotepEntities();


        public Cliente()
        {
            InitializeComponent();
            SetDataGrid();


        }

        public void SetDataGrid()
        {

            ClientesdataGridView.DataSource = dbtaller.Clientes.ToList();
        }
        public void limpiarCampos()
        {
            idCliente.Value = 0;
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            CedulatextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
        }

        public void TomarDatos()
        {

            var clienteA = new Conexion.Clientes();

            clienteA.nombre = this.NombretextBox.Text;
            clienteA.apellido = this.ApellidotextBox.Text;
            clienteA.cedula = this.CedulatextBox.Text;
            clienteA.direccion = this.DirecciontextBox.Text;
            clienteA.telefono = this.TelefonotextBox.Text;

            clienteA.fecha_registro = DateTime.Now;


            dbtaller.Clientes.Add(clienteA);
            dbtaller.SaveChanges();

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            TomarDatos();
            SetDataGrid();
            limpiarCampos();
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientesE = dbtaller.Clientes.Find(idCliente.Value);
            dbtaller.Clientes.Remove(clientesE);
            dbtaller.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();
            limpiarCampos();
        }



        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            
            Clientes clientesE = dbtaller.Clientes.Find(idCliente.Value);       
            clientesE.nombre = this.NombretextBox.Text;
            clientesE.apellido = this.ApellidotextBox.Text;
            clientesE.cedula = this.CedulatextBox.Text;
            clientesE.telefono = this.TelefonotextBox.Text;
            clientesE.direccion = this.DirecciontextBox.Text;            

            //dbtaller.Entry(clientesE).State = System.Data.Entity.EntityState.Modified;
            dbtaller.SaveChanges();

            MessageBox.Show("Se a modificado");

            limpiarCampos();
            SetDataGrid();

        } 


        private void button1_Click(object sender, EventArgs e)
        {
            
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.ShowDialog();
            

        }

        private void RellenarCampos(object sender, DataGridViewCellEventArgs e)
        {
            idCliente.Value = decimal.Parse(ClientesdataGridView.CurrentRow.Cells[0].Value.ToString());
            NombretextBox.Text = ClientesdataGridView.CurrentRow.Cells[1].Value.ToString();
            ApellidotextBox.Text = ClientesdataGridView.CurrentRow.Cells[2].Value.ToString();
            CedulatextBox.Text = ClientesdataGridView.CurrentRow.Cells[3].Value.ToString();
            DirecciontextBox.Text = ClientesdataGridView.CurrentRow.Cells[4].Value.ToString();
            TelefonotextBox.Text = ClientesdataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void ClientesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    }
    
