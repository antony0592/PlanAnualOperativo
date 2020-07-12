using RegistroPolicial.Domain.Entities;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class PaoView
    {
        public  PAO_Objetivo PAO_Objetivo { set; get; }
        public  PAO_Avance PAO_Avance { get; set; }
        public  PAO_Meta PAO_Meta { get; set; }
        public PAO_Coordinacion PAO_Coordinacion { get; set; }
        public PAO_Actividad PAO_Actividad { get; set; }
        public PAO_EjeTematico PAO_EjeTematico { get; set; }
    }
}