//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTaller.Conexion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturacion
    {
        public int id_factura { get; set; }
        public Nullable<System.DateTime> fecha_salida { get; set; }
        public Nullable<int> id_mecanico { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_taller { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> subtotal { get; set; }
        public Nullable<int> total { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Mecanicos Mecanicos { get; set; }
        public virtual Taller Taller { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
