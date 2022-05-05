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
    public partial class Cliente : Form
    {
        Conexion.db_TallerEntities dbtaller = new Conexion.db_TallerEntities();


        public Cliente()
        {
            InitializeComponent();
            SetDataGrid();


        }

        public void SetDataGrid()
        {

            ClientesdataGridView.DataSource = dbtaller.Clientes.ToList();
        }


        public void TomarDatos()
        {

            Conexion.Clientes clienteA = new Conexion.Clientes();



            clienteA.nombre = this.NombretextBox.Text;
            clienteA.apellido = this.ApellidotextBox.Text;
            clienteA.cedula = this.ApellidotextBox.Text;
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
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(this.textBox1.Text);
            Conexion.Clientes ClienteB = dbtaller.Clientes.Find(ID);
            dbtaller.Clientes.Remove(ClienteB);
            dbtaller.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();
        }

        public void Editar()
        {
            Conexion.Clientes clienteE = new Conexion.Clientes();

            this.NombretextBox.Text = clienteE.nombre;
            this.ApellidotextBox.Text = clienteE.apellido;
            this.CedulatextBox.Text = clienteE.cedula;
            this.TelefonotextBox.Text = clienteE.telefono;
            this.DirecciontextBox.Text = clienteE.direccion;
        }


        private void Modificarbutton_Click(object sender, EventArgs e)
        {



            String Nombre = this.NombretextBox.Text;
            string Apellido = this.ApellidotextBox.Text;
            string Cedula = this.CedulatextBox.Text;
            string Telefono = this.TelefonotextBox.Text;
            string Direccion = this.DirecciontextBox.Text;
            int ID = int.Parse(this.textBox1.Text);


            Conexion.Clientes clientesE = dbtaller.Clientes.Find(ID);

            clientesE.nombre = Nombre;
            clientesE.apellido = Apellido;
            clientesE.cedula = Cedula;
            clientesE.telefono = Telefono;
            clientesE.direccion = Direccion;
            clientesE.fecha_registro = DateTime.Now;



            dbtaller.Entry(clientesE).State = System.Data.Entity.EntityState.Modified;
            dbtaller.SaveChanges();

            MessageBox.Show("Se a modificado");

            SetDataGrid();

        } 

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(this.ClientesdataGridView.CurrentRow.Cells["id_cliente"].Value);
            Conexion.Clientes Cli = new Conexion.Clientes();
            var valor = dbtaller.Clientes.Where(x => x.id_cliente == id).FirstOrDefault();

            this.NombretextBox.Text = valor.nombre;
            this.ApellidotextBox.Text = valor.apellido;
            this.CedulatextBox.Text = valor.cedula;
            this.TelefonotextBox.Text = valor.telefono;
            this.DirecciontextBox.Text = valor.direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.ShowDialog();
            

        }
    }
    }
    
