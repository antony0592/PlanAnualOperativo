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
    
    public partial class PAO_Avance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAO_Avance()
        {
            this.PAO_Actividad = new HashSet<PAO_Actividad>();
        }
    
        public int IdAvance { get; set; }
        public string Oficina { get; set; }
        public string Objetivo { get; set; }
        public string Comentario { get; set; }
        public Nullable<int> Anno { get; set; }
        public string FechaActividad { get; set; }
        public string FileUrl { get; set; }
        public Nullable<int> Terminado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAO_Actividad> PAO_Actividad { get; set; }
    }
}
