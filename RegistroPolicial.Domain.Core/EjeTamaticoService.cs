using RegistroPolicial.Domain.Interfaces.Repositories;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Entities;

namespace RegistroPolicial.Domain.Core
{
    public class EjeTematicoService:BaseService<PAO_EjeTematico>, IEjeTematicoService
    {
        private readonly IEjeTematicoRepository repository;

        public EjeTematicoService(IEjeTematicoRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
