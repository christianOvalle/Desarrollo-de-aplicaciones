//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTranslogic.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class safe_journey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public safe_journey()
        {
            this.companiaproveedoras = new HashSet<companiaproveedoras>();
        }
    
        public int id_safe { get; set; }
        public string nombre { get; set; }
        public string RNC { get; set; }
        public string direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<companiaproveedoras> companiaproveedoras { get; set; }
    }
}
