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
    public partial class Factura : Form
    {
        int id_cliente = 0;
        int id_vehiculo = 0;
        int id_mecanico = 0;
        int id_Taller = 0;
        Conexion.db_taller_infotepEntities db_Taller = new Conexion.db_taller_infotepEntities();
        Conexion.Facturacion facturacion = new Conexion.Facturacion();

        public Factura()
        {
            InitializeComponent();
            addClientes();
        }

        public void addClientes() {

            var datosc = (from cli in db_Taller.Clientes
                         select new
                          {
                              cli.id_cliente,
                              cli.nombre,
                              cli.apellido,
                              cli.cedula,
                              cli.direccion,
                              cli.telefono,
                              cli.fecha_registro
                          }).ToList();

            dataGridViewFactura.DataSource = datosc;
            foreach (var item in datosc) id_cliente = int.Parse(item.id_cliente.ToString());
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
    }
}
