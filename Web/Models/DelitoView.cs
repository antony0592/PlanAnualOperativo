using RegistroPolicial.Domain.Entities;
using System.Collections.Generic;

namespace Web.Models
{
    public class DelitoView
    {
        public Delito delito { set; get; }
        public PersonaJuridica personaJuridica { set; get; }
        public List<PersonaJuridica> personaJuridicas { set; get; }
    }
}