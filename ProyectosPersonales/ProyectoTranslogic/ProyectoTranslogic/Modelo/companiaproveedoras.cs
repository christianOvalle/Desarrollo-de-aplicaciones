//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTranslogic.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class companiaproveedoras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public companiaproveedoras()
        {
            this.vehiculos = new HashSet<vehiculos>();
        }
    
        public int id_compania { get; set; }
        public string nombre { get; set; }
        public string rnc { get; set; }
        public string direccion { get; set; }
        public string cantidad_Buses { get; set; }
        public Nullable<int> id_safe { get; set; }
    
        public virtual safe_journey safe_journey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehiculos> vehiculos { get; set; }
    }
}
