using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Interfaces.Repositories;

namespace RegistroPolicial.Domain.Core
{
    public class CoordinacionService : BaseService<PAO_Coordinacion>, ICoodinacionService
    {
        private readonly ICoordinacionRepository repository;

        public CoordinacionService(ICoordinacionRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
