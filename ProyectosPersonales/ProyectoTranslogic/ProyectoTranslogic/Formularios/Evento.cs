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
    public partial class Evento : Form
    {
        Modelo.db_TranslogicEntities8 db = new Modelo.db_TranslogicEntities8();

        public Evento()
        {
            InitializeComponent();
            llenarCombo();
            setData();
        }

        public void setData() {

            var consultaevento = (from even in db.eventos
                                  join cli in db.cliente
                                  on even.id_cliente equals cli.id_cliente
                                  select new
                                  {
                                      even.id_evento,
                                      even.nombre_evento,
                                      even.ciudad_evento,
                                      even.tipo_de_evento,
                                      even.fecha_de_evento,
                                      even.fecha_registro_de_event,
                                      even.fecha_hacia_evento,
                                      even.fecha_hacia_casa,
                                      cli.id_cliente,
                                      cli.nombre_cliente
                                      

                                  }
                    ).ToList();

            dataGridViewP.DataSource = consultaevento;
            this.labelEventos.Text = dataGridViewP.Rows.Count.ToString() + " Registros encontrados";
          

        }


        public void llenarCombo() {

            this.comboBoxEventos.Items.Add("Personal");
            this.comboBoxEventos.Items.Add("Empresarial");
            this.comboBoxEventos.Items.Add("Turismo");


            var clienteConsulta = (from cli in db.cliente
                                   select new
                                   { cli.id_cliente,
                                       ListaClientes = cli.nombre_cliente + " " + cli.apellido_cliente
                                   }
                ).ToList();

            comboBoxClientes.DataSource = clienteConsulta;
            comboBoxClientes.DisplayMember = "ListaClientes";
            comboBoxClientes.ValueMember = "id_cliente";
            



        }

        public void agregar(){

            Modelo.eventos eve = new Modelo.eventos();

            eve.nombre_evento = textBoxEventoNombre.Text;
            eve.ciudad_evento = textBoxEventociudad.Text;
            eve.tipo_de_evento = comboBoxEventos.Text;
            eve.fecha_de_evento = dateTimePicker1.Text;
            eve.fecha_registro_de_event = DateTime.Now;
            eve.fecha_hacia_evento = textBoxHS.Text;
            eve.fecha_hacia_casa = textBoxHLL.Text;
            eve.id_cliente = int.Parse(this.comboBoxClientes.SelectedValue.ToString());

            db.eventos.Add(eve);
            MessageBox.Show("Registro Agregado");
            db.SaveChanges();
            setData();
        
        
        }

        public void editar() {

            int id = Convert.ToInt32(dataGridViewP.CurrentRow.Cells[0].Value);
            Modelo.eventos evento = db.eventos.Find(id);
            evento.nombre_evento = textBoxEventoNombre.Text;
            evento.ciudad_evento = textBoxEventociudad.Text;
            evento.tipo_de_evento = comboBoxEventos.Text;
            evento.fecha_hacia_evento = textBoxHS.Text;
            evento.fecha_hacia_casa = textBoxHLL.Text;

            db.Entry(evento).State = System.Data.Entity.EntityState.Modified;
            MessageBox.Show("Registro Editado");
            db.SaveChanges();
            setData();
        
        }
        public void borrar() {

            int id = Convert.ToInt32(dataGridViewP.CurrentRow.Cells[0].Value);
            Modelo.eventos eve = db.eventos.Find(id);
            db.eventos.Remove(eve);
            MessageBox.Show("Registro Borrado");
            db.SaveChanges();
            setData();


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

       
    }
}
