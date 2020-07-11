namespace RegistroPolicial.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DelitoPersonaJuridica
    {
        public int id { get; set; }
        public Nullable<int> idDelito { get; set; }
        public Nullable<int> idPersonaJuridica { get; set; }
    
        public virtual Delito Delito { get; set; }
        public virtual PersonaJuridica PersonaJuridica { get; set; }
    }
}
