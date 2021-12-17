using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion
{
    public class Cliente
    {
        public Cliente(int iD, string nombre, string apellido)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
        }

        public int ID { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }

    }
}
