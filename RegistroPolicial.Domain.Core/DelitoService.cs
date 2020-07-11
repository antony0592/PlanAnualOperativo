using RegistroPolicial.Domain.Interfaces.Repositories;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Entities;

namespace RegistroPolicial.Domain.Core
{
    public class DelitoService:BaseService<Delito>, IDelitoService
    {
        private readonly IDelitoRepository repository;

        public DelitoService(IDelitoRepository repository) :base(repository)
        {
            this.repository = repository;
        }
    }
}