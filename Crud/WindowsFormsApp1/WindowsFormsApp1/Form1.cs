using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySql.Data.MySqlClient.MySqlConnectionStringBuilder Mibase = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
        Mibase.Database = "pruebaconexion";
            Mibase.Password = "";
            Mibase.UserID = "root";
            Mibase.Server = "localhost";
            Mibase.IntegratedSecurity = false;
            //Mibase.Port = 3306;

            string Muestra = Mibase.ConnectionString;


    }
}
