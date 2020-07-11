using RegistroPolicial.Domain.Interfaces.Repositories;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Entities;

namespace RegistroPolicial.Domain.Core
{
    public class DelitoPersonaJuridicaService : BaseService<DelitoPersonaJuridica>, IDelitoPersonaJuridicaService
    {
        private readonly IDelitoPersonaJuridicaRepository repository;

        public DelitoPersonaJuridicaService(IDelitoPersonaJuridicaRepository repository) :base(repository)
        {
            this.repository = repository;
        }
    }
}