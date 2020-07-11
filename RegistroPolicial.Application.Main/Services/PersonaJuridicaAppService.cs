using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Application.Main.Interfaces;

namespace RegistroPolicial.Application.Main.Services
{
    public class PersonaJuridicaAppService : BaseAppService<PersonaJuridica>, IPersonaJuridicaAppService
    {        
        private readonly IPersonaJuridicaService service;
        
        public PersonaJuridicaAppService(IPersonaJuridicaService service) :base(service)
        {
            this.service = service;
        }
    }
}