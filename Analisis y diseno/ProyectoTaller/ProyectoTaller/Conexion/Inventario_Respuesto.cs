//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTaller.Conexion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario_Respuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventario_Respuesto()
        {
            this.Detalle_Reparacion = new HashSet<Detalle_Reparacion>();
        }
    
        public int id_inventario { get; set; }
        public string nombre_pieza { get; set; }
        public Nullable<int> precio_pieza { get; set; }
        public Nullable<int> cantidad_disponible { get; set; }
        public string estado_piezas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Reparacion> Detalle_Reparacion { get; set; }
    }
}