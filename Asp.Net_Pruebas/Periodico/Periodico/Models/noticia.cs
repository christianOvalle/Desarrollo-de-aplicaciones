//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Periodico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class noticia
    {
        public int id { get; set; }
        public Nullable<int> categoria_id { get; set; }
        public string titulo { get; set; }
        public string detale_completo { get; set; }
        public string detalle_corto { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public byte[] imagen { get; set; }
        public string ruta_imagen { get; set; }
    
        public virtual categoria categoria { get; set; }
    }
}
