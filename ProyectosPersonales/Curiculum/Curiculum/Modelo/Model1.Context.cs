﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CurriculumEntities : DbContext
    {
        public CurriculumEntities()
            : base("name=CurriculumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DatosPersonales> DatosPersonales { get; set; }
        public virtual DbSet<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public virtual DbSet<Formacion_Y_estudios> Formacion_Y_estudios { get; set; }
        public virtual DbSet<Fotos> Fotos { get; set; }
    }
}