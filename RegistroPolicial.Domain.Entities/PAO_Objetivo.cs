//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistroPolicial.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAO_Objetivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAO_Objetivo()
        {
            this.PAO_Coordinacion = new HashSet<PAO_Coordinacion>();
            this.PAO_Meta = new HashSet<PAO_Meta>();
        }
    
        public int IdObjetivo { get; set; }
        public Nullable<int> IdTematico { get; set; }
        public Nullable<int> Anno { get; set; }
        public string Oficina { get; set; }
        public string TemaEstretegico { get; set; }
        public string Objetivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAO_Coordinacion> PAO_Coordinacion { get; set; }
        public virtual PAO_EjeTematico PAO_EjeTematico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAO_Meta> PAO_Meta { get; set; }
    }
}
