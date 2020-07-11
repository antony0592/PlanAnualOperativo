namespace RegistroPolicial.Infraestructure.Data
{

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RegistroPolicial.Domain.Entities;

    public partial class RegistroPolicialEntities : DbContext
    {
        public RegistroPolicialEntities(): base("name=RegistroPolicialEntities")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Delito> Delito { get; set; }

        public virtual DbSet<DelitoPersonaJuridica> DelitoPersonaJuridica { get; set; }

        public virtual DbSet<PersonaJuridica> PersonaJuridica { get; set; }

    }
}

