//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Curiculum.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatosPersonales
    {
        public int id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string LugarDeNacimineto { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public Nullable<int> Telefono { get; set; }
        public Nullable<int> TelefonoCelular { get; set; }
        public string Email { get; set; }
    }
}