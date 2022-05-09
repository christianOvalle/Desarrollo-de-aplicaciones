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
    public partial class Piezas : Form
    {

        Conexion.db_taller_infotepEntities db_ = new Conexion.db_taller_infotepEntities();

        public Piezas()
        {
            InitializeComponent();
            SetDataGrid();
        }

        public void SetDataGrid()
        {

            var datosP = (from pie in db_.Inventario_Respuesto
                          select new
                          {
                              pie.id_inventario,
                              pie.nombre_pieza,
                              pie.precio_pieza,
                              pie.cantidad_disponible,
                              pie.estado_piezas
                          }).ToList();
            dataGridViewHerramientas.DataSource = datosP;  
        }
        public void reset() {

            radioButtonnueva.Checked = false;
            radioButtonusada.Checked = false;
        
        }

        public void TomarDatos()
        {

            var herramientaA = new Conexion.Inventario_Respuesto();

            herramientaA.nombre_pieza = this.textBoxnombrepieza.Text;
            
            herramientaA.precio_pieza = Convert.ToInt32(this.textBoxpreciodepieza.Text);
            herramientaA.cantidad_disponible = Convert.ToInt32(this.textBoxcantidaddisponible.Text);
            if (radioButtonnueva.Checked)
            {
                herramientaA.estado_piezas = "Nueva";
            }
            else if(radioButtonusada.Checked) {
                herramientaA.estado_piezas = "Usada";   
            }


            db_.Inventario_Respuesto.Add(herramientaA);
            db_.SaveChanges();
            reset();

        }

        public void borrar()
        {

            int ID = Convert.ToInt32(dataGridViewHerramientas.CurrentRow.Cells["id_inventario"].Value.ToString());
            var herramientasB = db_.Inventario_Respuesto.Find(ID);
            db_.Inventario_Respuesto.Remove(herramientasB);
            db_.SaveChanges();

            MessageBox.Show("Se elimino correctamente");
            SetDataGrid();
            reset();
        }

        public void editar()
        {

            String nombreP = this.textBoxnombrepieza.Text;           
            int precioP = Convert.ToInt32(this.textBoxpreciodepieza.Text);
            int cantidad_dP = Convert.ToInt32(this.textBoxcantidaddisponible.Text);
            int ID = Convert.ToInt32(dataGridViewHerramientas.CurrentRow.Cells["id_inventario"].Value.ToString());


            var herramientasE = db_.Inventario_Respuesto.Find(ID);

            herramientasE.nombre_pieza = nombreP;          
            herramientasE.precio_pieza = precioP;
            herramientasE.cantidad_disponible = cantidad_dP;
            if (radioButtonnueva.Checked)
            {
                herramientasE.estado_piezas = "Nueva";
            }
            else if (radioButtonusada.Checked)
            {
                herramientasE.estado_piezas = "Usada";
            }


            db_.Entry(herramientasE).State = System.Data.Entity.EntityState.Modified;
            db_.SaveChanges();

            MessageBox.Show("Se a modificado");

            SetDataGrid();
            reset();

        }



        private void buttonPiezaadd_Click(object sender, EventArgs e)
        {
            TomarDatos();
            SetDataGrid();
        }
       
        private void buttondeletepiezza_Click(object sender, EventArgs e)
        {
            borrar();

        }

      

        private void buttoneditpiezza_Click(object sender, EventArgs e)
        {
            editar();
        }

      

        private void dataGridViewHerramientas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(this.dataGridViewHerramientas.CurrentRow.Cells["id_inventario"].Value);
            var valor = db_.Inventario_Respuesto.Find(id);

            this.textBoxnombrepieza.Text = valor.nombre_pieza;
            this.textBoxpreciodepieza.Text = valor.precio_pieza.ToString();
            this.textBoxcantidaddisponible.Text = valor.cantidad_disponible.ToString();
        }
    }
    }


