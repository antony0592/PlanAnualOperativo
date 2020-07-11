using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Application.Main.Interfaces;

namespace RegistroPolicial.Application.Main.Services
{
    public class DelitoPersonaJuridicaAppService : BaseAppService<DelitoPersonaJuridica>, IDelitoPersonaJuridicaAppService
    {        
        private readonly IDelitoPersonaJuridicaService service;
        
        public DelitoPersonaJuridicaAppService(IDelitoPersonaJuridicaService service) :base(service)
        {
            this.service = service;
        }
    }
}