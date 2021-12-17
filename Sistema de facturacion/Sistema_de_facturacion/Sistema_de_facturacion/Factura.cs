using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion
{
    class Factura
    {
        public Factura(int iD, int clienteID, int usuarioID, float total)
        {
            ID = iD;
            ClienteID = clienteID;
            UsuarioID = usuarioID;
            Total = total;
        }

        public Factura()
        {
        }

        public int ID { set; get; }
        public int ClienteID { set; get; }
        public int UsuarioID { set; get; }
        public float Total { set; get; }
    }
}
