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
    
    public partial class Vehiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculos()
        {
            this.Detalle_Reparacion = new HashSet<Detalle_Reparacion>();
            this.Facturacion = new HashSet<Facturacion>();
            this.Mecanicos = new HashSet<Mecanicos>();
        }
    
        public int id_vehiculo { get; set; }
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public Nullable<int> id_cliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Reparacion> Detalle_Reparacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturacion> Facturacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mecanicos> Mecanicos { get; set; }
    }
}
