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
    
    public partial class Detalle_Reparacion
    {
        public int id_detalle { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> id_inventario { get; set; }
        public Nullable<int> precio { get; set; }
        public string cantidad { get; set; }
        public Nullable<int> mano_obra { get; set; }
        public Nullable<int> id_servicio { get; set; }
    
        public virtual Inventario_Respuesto Inventario_Respuesto { get; set; }
        public virtual Servicios Servicios { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
