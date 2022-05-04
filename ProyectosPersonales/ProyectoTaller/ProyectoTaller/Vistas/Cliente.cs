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

            dataGridView1.DataSource = dbtaller.Clientes.ToList();
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

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ddebe ingresar un id en el campo id");

            }

            else {
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
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion.Clientes Cli = new Conexion.Clientes();

            this.NombretextBox.Text = Cli.nombre;
            this.ApellidotextBox.Text = Cli.apellido;
            this.CedulatextBox.Text = Cli.cedula;
            this.TelefonotextBox.Text = Cli.telefono;
            this.DirecciontextBox.Text = Cli.direccion;
        }
    }
    }
    

       /* public void Limpiar() {
            this.NombretextBox.Text = "";
            this.ApellidotextBox.Text = "";
            this.DirecciontextBox.Text = "";
            this.TelefonotextBox.Text = "";
            this.ApellidotextBox.Text = "";


        }

        public void Editar() { 
        
       
                this.NombretextBox.Text = Cli.nombre;
                this.ApellidotextBox.Text = Cli.apellido;
                this.CedulatextBox.Text = Cli.cedula;
                this.TelefonotextBox.Text = Cli.telefono;
                this.DirecciontextBox.Text = Cli.direccion;

                dbtaller.Entry(Cli).State = System.Data.Entity.EntityState.Modified;

                dbtaller.SaveChanges();


            }

        }

        public void TomarDatos() {

            Cli.nombre = this.NombretextBox.Text;
            Cli.apellido = this.ApellidotextBox.Text;
            Cli.cedula = this.ApellidotextBox.Text;
            Cli.direccion = this.DirecciontextBox.Text;
            Cli.telefono = this.TelefonotextBox.Text;
            Cli.fecha_registro = DateTime.Now;

            using (Conexion.db_TallerEntities dbtaller = new Conexion.db_TallerEntities()) {

                if (Cli.id_cliente == 0)
                {
                    dbtaller.Clientes.Add(Cli);
                }
                else {

                    dbtaller.Entry(Cli).State = System.Data.Entity.EntityState.Modified;

                dbtaller.SaveChanges();
                }
            }
          

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
       */