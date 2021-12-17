using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion
{
    class FacturaDetalle
    {
        public FacturaDetalle(int iD, int facturaID, int productoID, string producto, float precio, float cantidad, float subTotal)
        {
            ID = iD;
            FacturaID = facturaID;
            ProductoID = productoID;
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }


        public FacturaDetalle()
        {
        }

        public int ID { set; get; }
        public int FacturaID { set; get; }
        public int ProductoID { set; get; }
        public string Producto { set; get; }
        public float Precio { set; get; }
        public float Cantidad { set; get; }
        public float SubTotal { set; get; }


    }
}
