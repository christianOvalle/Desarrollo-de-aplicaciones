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

namespace ProyectoTaller
{
    public partial class detalleForm : Form
    {
        db_taller_infotepEntities conexion = new db_taller_infotepEntities();

        public detalleForm()
        {
            InitializeComponent();
        }
        private void llenarDgv()
        {
            dataGridView1.DataSource = conexion.Detalle_Reparacion.ToList();
        }

        private void llenarCombos()
        {
            var tablaVeh = (from veh in conexion.Vehiculos
                           select new {
                               veh.matricula,
                               veh.id_vehiculo
                           }).ToList();

            matriculaVehiculo.DataSource = tablaVeh;
            matriculaVehiculo.DisplayMember = "matricula";
            matriculaVehiculo.ValueMember = "id_vehiculo";

            var tablaPieza = (from pieza in conexion.Inventario_Respuesto
                              select new
                              {
                                  pieza.id_inventario,
                                  pieza.nombre_pieza
                              }).ToList();

            piezaRepuesto.DataSource = tablaPieza;
            piezaRepuesto.DisplayMember = "nombre_pieza";
            piezaRepuesto.ValueMember = "id_inventario";

            var tablaServicio = (from servicio in conexion.Servicios
                                 select new
                                 {
                                     servicio.id_servicio,
                                     servicio.tipo_servicio
                                 }).ToList();

            manoObra.DataSource = tablaServicio;
            manoObra.DisplayMember = "tipo_servicio";
            manoObra.ValueMember = "id_servicio";
        }

        private void detalleForm_Load(object sender, EventArgs e)
        {
            llenarDgv();
            llenarCombos();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {            
            Inventario_Respuesto inv = conexion.Inventario_Respuesto.Find(piezaRepuesto.SelectedValue);
            precioPieza.Value = decimal.Parse(inv.precio_pieza.ToString());

            Servicios serv = conexion.Servicios.Find(manoObra.SelectedValue);
            precioManoObra.Value = decimal.Parse(serv.costo.ToString());

            
           
          

            Detalle_Reparacion detalle = new Detalle_Reparacion();
            detalle.id_vehiculo = int.Parse(matriculaVehiculo.SelectedValue.ToString());
            detalle.id_inventario = int.Parse(piezaRepuesto.SelectedValue.ToString());
            detalle.cantidad = cantidad.Value.ToString();
            detalle.id_servicio = int.Parse(manoObra.SelectedValue.ToString());
            decimal subtotal = (precioPieza.Value * cantidad.Value) + precioManoObra.Value;
            detalle.mano_obra = int.Parse(subtotal.ToString());
            detalle.precio = inv.precio_pieza;

           
            
            
            
            

            conexion.Detalle_Reparacion.Add(detalle);
            conexion.SaveChanges();
            llenarDgv();
        }

        

       
    }
}
