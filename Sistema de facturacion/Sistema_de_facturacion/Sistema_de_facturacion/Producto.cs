using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion
{
    class Producto
    {
        public Producto(int iD, string nombre, float apellido)
        {
            ID = iD;
            Nombre = nombre;
            Precio = apellido;
        }

        public Producto()
        {
        }

        public int ID { set; get; }
        public string Nombre { set; get; }
        public float Precio { set; get; }


    }
}
