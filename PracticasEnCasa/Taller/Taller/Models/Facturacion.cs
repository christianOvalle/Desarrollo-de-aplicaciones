//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taller.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturacion
    {
        public int id { get; set; }
        public string rnc_taller { get; set; }
        public string modelo_vehiculo { get; set; }
        public string marca_vehiculo { get; set; }
        public string color_vehiculo { get; set; }
        public string nombre_servicio { get; set; }
        public string nombre_taller { get; set; }
        public string direccion_taller { get; set; }
        public string telefono_taller { get; set; }
        public Nullable<int> costo_trabajo { get; set; }
    }
}
