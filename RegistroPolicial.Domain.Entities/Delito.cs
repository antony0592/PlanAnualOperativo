namespace RegistroPolicial.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    public partial class Delito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delito()
        {
            this.DelitoPersonaJuridica = new HashSet<DelitoPersonaJuridica>();
        }
    
        public int id { get; set; }
        public string origen { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string modalidad { get; set; }
        public string victima { get; set; }
        public string subVictima { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string oficina { get; set; }
        public string delegacion { get; set; }
        public string perjuicio { get; set; }
        public string moneda { get; set; }
        public string tentativa { get; set; }
        public string observaciones { get; set; }
        public string narracion { get; set; }
        public string numeroUnico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<DelitoPersonaJuridica> DelitoPersonaJuridica { get; set; }
    }
}
