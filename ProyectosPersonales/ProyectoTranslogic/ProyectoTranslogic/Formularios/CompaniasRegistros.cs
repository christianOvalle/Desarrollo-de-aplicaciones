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
    public partial class CompaniasRegistros : Form

    {

        Modelo.dbTransloEntities1 DB = new Modelo.dbTransloEntities1();

        public CompaniasRegistros()
        {
            InitializeComponent();
            setdata();
        }

        public void setdata() {

            var consultaCompa = (from objC in DB.companiaproveedoras
                                 select new
                                 {
                                     objC.id_compania,
                                     objC.nombre,
                                     objC.rnc,
                                     objC.direccion

                                 }


                    ).ToList();
        
        dataGridViewCompa.DataSource = consultaCompa;
        }

        public void add() {

            Modelo.companiaproveedoras compa = new Modelo.companiaproveedoras();
            compa.nombre = texboxNombreC.Text;
            compa.rnc = textBoxRNC.Text;
            compa.direccion = textBoxDireccion.Text;

            DB.companiaproveedoras.Add(compa);           
            DB.SaveChanges();
            MessageBox.Show("Agregado");
            setdata();    
        
        }


        public void edita() {
            int id = Convert.ToInt32(dataGridViewCompa.CurrentRow.Cells[0].Value);

        Modelo.companiaproveedoras cp = DB.companiaproveedoras.Find(id);
        cp.nombre = texboxNombreC.Text;
        cp.direccion = textBoxDireccion.Text;
        cp.rnc = textBoxRNC.Text;
            
        DB.Entry(cp).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            MessageBox.Show("Editado");
            setdata();


        }

        public void delete() {
            int id = Convert.ToInt32(dataGridViewCompa.CurrentRow.Cells[0].Value);
            Modelo.companiaproveedoras cp = DB.companiaproveedoras.Find(id);
            DB.companiaproveedoras.Remove(cp);
            DB.SaveChanges();
            MessageBox.Show("Borrado");
            setdata();


        }

        private void LlenarCampos(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCompa.CurrentRow.Cells[0].Value);
            Modelo.companiaproveedoras cp = DB.companiaproveedoras.Find(id);
            texboxNombreC.Text = cp.nombre;
            textBoxDireccion.Text = cp.direccion;
            textBoxRNC.Text = cp.rnc;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            add();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            edita();
        }
    }
}
