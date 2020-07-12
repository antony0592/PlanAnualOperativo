using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Interfaces.Repositories;

namespace RegistroPolicial.Domain.Core
{
    public class AvanceService : BaseService<PAO_Avance>, IAvanceService
    {
        private readonly IAvanceRepository repository;

        public AvanceService(IAvanceRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
