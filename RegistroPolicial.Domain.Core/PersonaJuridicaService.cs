using RegistroPolicial.Domain.Interfaces.Repositories;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Entities;

namespace RegistroPolicial.Domain.Core
{
    public class PersonaJuridicaService : BaseService<PersonaJuridica>, IPersonaJuridicaService
    {
        private readonly IPersonaJuridicaRepository repository;

        public PersonaJuridicaService(IPersonaJuridicaRepository repository) :base(repository)
        {
            this.repository = repository;
        }
    }
}