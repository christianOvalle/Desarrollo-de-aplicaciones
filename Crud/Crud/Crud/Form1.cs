using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conector = null;
        private string id;


        public Form1()

        {
            InitializeComponent();
            this.leer();
        }

        public void conectar()
        {

            MySqlConnectionStringBuilder mySqConnectionStringBuilder = new MySqlConnectionStringBuilder();
            mySqConnectionStringBuilder.Database = "pruebaconexion";
            mySqConnectionStringBuilder.Password = "";
            mySqConnectionStringBuilder.UserID = "root";
            mySqConnectionStringBuilder.Server = "localhost";
            mySqConnectionStringBuilder.IntegratedSecurity = false;

            Conector = new MySqlConnection(mySqConnectionStringBuilder.ConnectionString);
            Conector.Open();


        }

        public void cerrar()
        {
            this.Conector.Close();

        }

        public void buscador()
        {

            leer($"where nombre like '%{this.textBox1.Text}%' ");

        }

        public void leer(string buscar = "")
        {
            this.conectar();
            MySqlCommand mySqlCommand = this.Conector.CreateCommand();
            mySqlCommand.CommandText = $"select *from personas {buscar} ";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            this.dataGridView1.Rows.Clear();
            while (mySqlDataReader.Read())
            {
                this.dataGridView1.Rows.Add(
                    mySqlDataReader["id"].ToString(),
                    mySqlDataReader["nombre"].ToString(),
                    mySqlDataReader["cedula"].ToString()
                    );
            }
            this.cerrar();


        }

        public void insertar()
        {

            this.conectar();
            MySqlCommand mySqlCommand = this.Conector.CreateCommand();
            mySqlCommand.CommandText = "insert into personas(nombre,cedula) values(@nombre,@cedula);";
            mySqlCommand.Parameters.Add(new MySqlParameter("@nombre", this.textBox2.Text));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cedula", this.textBox3.Text));
            int registroafectados = mySqlCommand.ExecuteNonQuery();
            MessageBox.Show(registroafectados.ToString());

            this.cerrar();

        }

        public void update()
        {
            this.conectar();
            MySqlCommand mySqlCommand = this.Conector.CreateCommand();
            mySqlCommand.CommandText = "update personas set nombre = @nombre,cedula = @cedula where id = id ; ";
            mySqlCommand.Parameters.Add(new MySqlParameter("@nombre",
            this.textBox1.Text));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cedula",
            this.textBox1.Text));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id", this.id));
            int registrosAfectados = mySqlCommand.ExecuteNonQuery();
            MessageBox.Show(registrosAfectados.ToString());
            this.cerrar();
        }

        public void delete()
        {
            DialogResult respuestaUsuario = MessageBox.Show(
            $"Realmente desea eliminar este registro { this.textBox1.Text} con cedula { this.textBox2.Text} ", "Confirmacion",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
            if (respuestaUsuario == DialogResult.Yes)
            {
                this.conectar();
                MySqlCommand mySqlCommand = this.Conector.CreateCommand();
                mySqlCommand.CommandText = "delete from personas where id = @id; ";
                mySqlCommand.Parameters.Add(new MySqlParameter("@id", this.id));
                int registrosAfectados = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show(registrosAfectados.ToString());
                this.cerrar();
            }


        }

        public void cancel()
        {
            this.id = "0";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.insertar();
            this.leer();
            this.cancel();
        }

        private void dataGridView1_CellDoubleClick(object sender,DataGridViewCellEventArgs e)
        {
            this.id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString
            ();//columna 0 igual id
            this.textBox1.Text = this.dataGridView1.CurrentRow.Cells
            [1].Value.ToString();//columna 1 nombre
            this.textBox1.Text = this.dataGridView1.CurrentRow.Cells
            [2].Value.ToString();//columna 2 cedula
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            this.cancel();

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.Update();
            this.leer();
            this.cancel();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.delete();
            this.leer();
            this.cancel();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.buscador();
        }
    }

}