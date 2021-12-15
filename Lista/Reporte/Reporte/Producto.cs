using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporte
{
    class Producto
    {

        public int id { set; get; }

        public string nombre { set; get; }

        public float precio { set; get; }

        public float cantidad { set; get; }

        public double subTotal { set; get; }



        public Producto(int ID, string Nombre, float Precio, float Cantidad, double Subtotal)
        {

            id = ID;
            nombre = Nombre;
            precio = Precio;
            cantidad = Cantidad;
            subTotal = Subtotal;

        }

    }
}
