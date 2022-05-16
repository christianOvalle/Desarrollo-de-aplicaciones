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
    public partial class Factura : Form
    {
        int id_cliente = 0;
        int id_vehiculo = 0;
        int id_mecanico = 0;
        int id_Taller = 0;
        db_taller_infotepEntities db_Taller = new db_taller_infotepEntities();
        //Conexion.Facturacion facturacion = new Conexion.Facturacion();

        public Factura()
        {
            InitializeComponent();
            addClientes();
            llenarComboClie();
        }

        private void llenarComboClie()
        {
            var consultaClie = (from obj in db_Taller.Clientes
                               select new
                               {
                                   obj.id_cliente,
                                   NOMBRECOMPLETO = obj.nombre + " " + obj.apellido
                               }).ToList();

            cboClientes.DataSource = consultaClie;
            cboClientes.DisplayMember = "NOMBRECOMPLETO";
            cboClientes.ValueMember = "id_cliente";                        
        }

        public void addClientes() {

            var DetalleF = (from Df in db_Taller.Detalle_Reparacion
                            join invn in db_Taller.Inventario_Respuesto
                            on Df.id_inventario equals invn.id_inventario
                            join servn in db_Taller.Servicios
                            on Df.id_servicio equals servn.id_servicio

                            select new
                            {
                                Df.id_detalle,
                                invn.nombre_pieza,
                                servn.tipo_servicio,
                                Df.precio,
                                Df.cantidad,
                                Df.mano_obra
                            }).ToList();
            dataGridViewFactura.DataSource = DetalleF;
        }
        public void obtrner_id_vehiculo(){
        
            var consultaVehi = (from vehiculo in db_Taller.Vehiculos
                           join cliente in db_Taller.Clientes
                           on vehiculo.id_cliente equals cliente.id_cliente

                           select new { 
                           
                               vehiculo.id_vehiculo
                           }).ToList();

            foreach (var item in consultaVehi)
            {

                id_vehiculo = int.Parse(item.id_vehiculo.ToString());
            }
        
        }

        public void obtener_idMecanico() {

            var consultaMeca = (from Mecanico in db_Taller.Mecanicos
                            join vehiculo in db_Taller.Vehiculos
                            on Mecanico.id_mecanico equals vehiculo.id_vehiculo

                            select new
                            {

                                Mecanico.id_mecanico
                            }).ToList();

            foreach (var item in consultaMeca)
            {

                id_mecanico = int.Parse(item.id_mecanico.ToString());
            }


        }
        public void obtener_id_factura() {

            var consultaTaller = (from Taller in db_Taller.Taller                                                                              select new
                                {

                                    Taller.id_taller
                                }).ToList();

            foreach (var item in consultaTaller)
            {

                //id_mecanico = int.Parse(item.id_mecanico.ToString());
            }

        }


        public void Facturaadd() { 
        
            


        
        }

        private void dataGridViewFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_cliente = int.Parse(dataGridViewFactura.CurrentRow.Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes clie = db_Taller.Clientes.Find(cboClientes.SelectedValue);
            this.NombretextBox.Text = clie.nombre;
            this.ApellidotextBox.Text = clie.apellido;
            this.CedulatextBox.Text = clie.cedula;
            this.DirecciontextBox.Text = clie.direccion;
            this.TelefonotextBox.Text = clie.telefono;

            var selectVehiculo = (from obj in db_Taller.Vehiculos
                                 
                                 select new
                                 {
                                     obj.id_vehiculo
                                 }).ToList();

            int id_veh = 0;

            foreach (var id in selectVehiculo)
            {
                id_veh = id.id_vehiculo;
            }

            Mecanicos cli = db_Taller.Mecanicos.Find(id_veh);
            this.textBoxNombre.Text = cli.nombre;
            this.textBoxApellido.Text = cli.apellido;
            this.textBoxCedula.Text = cli.cedula;
            this.textBoxFecha.Text = cli.cedula;

        }

    }
}
