using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTranslogic.Formularios
{
    public partial class Cliente : Form

      
    {
        Modelo.dbTransloEntities1 db_Translogic = new Modelo.dbTransloEntities1();  

        public Cliente()
        {
            InitializeComponent();
            llenarComboBanco();
            setData();
        }


        public void llenarComboBanco() {

            this.comboBoxBanco.Items.Add("Popular");
            this.comboBoxBanco.Items.Add("Banreservas");
            this.comboBoxBanco.Items.Add("Ademi");
            this.comboBoxBanco.Items.Add("BHD Leon");
            this.comboBoxBanco.Items.Add("Scotiabank");
            this.comboBoxBanco.Items.Add("DBI");
            this.comboBoxBanco.Items.Add("Santa Cruz");

        }
        public void setData() {

            var ConsultaCliente = (from clien in db_Translogic.cliente                                                                 
                              select new
                                   {   
                                       clien.id_cliente,
                                       clien.nombre_cliente,
                                       clien.apellido_cliente,
                                       clien.cedula_cliente,
                                       clien.direccion_cliente,
                                       clien.numero_de_tarjeta,
                                       
                                       
                                   }).ToList();


            this.dataGridViewCliente.DataSource = ConsultaCliente;
            this.labelRegistros.Text = dataGridViewCliente.Rows.Count.ToString() + " Registros encontrados";
        }

        public void Agregar()
        {
            Modelo.cliente cliente = new Modelo.cliente();

            cliente.nombre_cliente = this.textBoxNombre.Text;
            cliente.apellido_cliente = this.textBoxapellido.Text;
            cliente.cedula_cliente = this.textBoxcedula.Text;
            cliente.direccion_cliente = this.textBoxdireccion.Text;
            cliente.numero_de_tarjeta = this.textBoxtarjeta.Text;
            //cliente.fe = DateTime.Now;
            if (this.comboBoxBanco.Text == "Eliga su banco" || this.comboBoxBanco.Text == "Eliga su banco")
            {

                MessageBox.Show("Debe elegir su banco");
            }
            else
            {
               // cliente.banco = this.comboBoxBanco.SelectedItem.ToString();

                db_Translogic.cliente.Add(cliente);
                db_Translogic.SaveChanges();
                MessageBox.Show("Registro Agregado");
                setData();
            }
        }

        public void editar() {

            int id = Convert.ToInt32(dataGridViewCliente.CurrentRow.Cells[0].Value);
            Modelo.cliente clienteE = db_Translogic.cliente.Find(id);
            clienteE.nombre_cliente = this.textBoxNombre.Text;
            clienteE.apellido_cliente = this.textBoxapellido.Text;
            clienteE.cedula_cliente = this.textBoxcedula.Text;
            clienteE.direccion_cliente = this.textBoxdireccion.Text;
            clienteE.numero_de_tarjeta = this.textBoxtarjeta.Text;
            //clienteE.fecha_registro = DateTime.Now;
            if (this.comboBoxBanco.Text == "Eliga su banco" || this.comboBoxBanco.Text == "Eliga su banco")
            {

                MessageBox.Show("Debe elegir su banco");
            }
            else
            {
               // clienteE.banco = this.comboBoxBanco.SelectedItem.ToString();



                db_Translogic.Entry(clienteE).State = System.Data.Entity.EntityState.Modified;
                db_Translogic.SaveChanges();
                MessageBox.Show("Registro Editado");
                setData();
            }

        }

        public void borrar() {

            int id = Convert.ToInt32(dataGridViewCliente.CurrentRow.Cells[0].Value);
            Modelo.cliente clienteB = db_Translogic.cliente.Find(id);
            db_Translogic.cliente.Remove(clienteB);
            db_Translogic.SaveChanges();
            MessageBox.Show("Registro Borrado");
            setData();

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            borrar();
        }
        private void buttoneditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void LlenarTextbox(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCliente.CurrentRow.Cells[0].Value);
            Modelo.cliente clienteLlenar = db_Translogic.cliente.Find(id);
            this.textBoxNombre.Text = clienteLlenar.nombre_cliente;
            this.textBoxapellido.Text = clienteLlenar.apellido_cliente;
            this.textBoxcedula.Text = clienteLlenar.cedula_cliente;
            this.textBoxdireccion.Text = clienteLlenar.direccion_cliente;
            this.textBoxtarjeta.Text = clienteLlenar.numero_de_tarjeta;
           // this.comboBoxBanco.Text = clienteLlenar.banco;
                
        }

       
    }
    }
