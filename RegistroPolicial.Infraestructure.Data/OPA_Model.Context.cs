using RegistroPolicial.Domain.Entities;


namespace RegistroPolicial.Infraestructure.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlanAnualOperativoAntony2020Entities : DbContext
    {
        public PlanAnualOperativoAntony2020Entities()
            : base("name=PlanAnualOperativoAntony2020Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PAO_Actividad> PAO_Actividad { get; set; }
        public virtual DbSet<PAO_Avance> PAO_Avance { get; set; }
        public virtual DbSet<PAO_Coordinacion> PAO_Coordinacion { get; set; }
        public virtual DbSet<PAO_EjeTematico> PAO_EjeTematico { get; set; }
        public virtual DbSet<PAO_Meta> PAO_Meta { get; set; }
        public virtual DbSet<PAO_Objetivo> PAO_Objetivo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
