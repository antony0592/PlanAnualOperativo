using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Interfaces.Repositories;

namespace RegistroPolicial.Domain.Core
{
    public class MetaService:BaseService<PAO_Meta>,IMetaService
    {
        private readonly IMetaRepository repository;

        public MetaService(IMetaRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
