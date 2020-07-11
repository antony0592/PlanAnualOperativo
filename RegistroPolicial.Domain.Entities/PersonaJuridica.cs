namespace RegistroPolicial.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonaJuridica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonaJuridica()
        {
            this.DelitoPersonaJuridica = new HashSet<DelitoPersonaJuridica>();
        }
    
        public int id { get; set; }
        public string rol { get; set; }
        public string cedulaJuridica { get; set; }
        public string nombre { get; set; }
        public string razon { get; set; }
        public string intensidad { get; set; }
        public string nombreFantasia { get; set; }
        public string atributo { get; set; }
        public string filial { get; set; }
        public Nullable<bool> allanada { get; set; }
        public string observaciones { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<DelitoPersonaJuridica> DelitoPersonaJuridica { get; set; }
    }
}
