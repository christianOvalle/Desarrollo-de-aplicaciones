﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicaconexion1
{
    class Program
    {
        static void Main(string[] args)
        {



            MySql.Data.MySqlClient.MySqlConnectionStringBuilder Mibase = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            Mibase.Database = "pruebaconexion";
            Mibase.Password = "";
            Mibase.UserID = "root";
            Mibase.Server = "localhost";
            Mibase.IntegratedSecurity = false;
            //Mibase.Port = 3306;

            string Muestra = Mibase.ConnectionString;

            MySql.Data.MySqlClient.MySqlConnection muestra = new MySql.Data.MySqlClient.MySqlConnection(Muestra);
            muestra.Open();
            Console.WriteLine("Hola");


            MySql.Data.MySqlClient.MySqlCommand Asignacion = muestra.CreateCommand();
            Asignacion.CommandText = "insert into producto(nombre,precio) values ('mango',56.23);";
            Asignacion.ExecuteNonQuery();
            Console.WriteLine("Todo correcto");

            Console.ReadKey();

        }
    }
}
