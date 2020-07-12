using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Domain.Core
{
    public class EjeTamaticoService:IBaseService<PAO_EjeTematico>, IEjeTematicoService
    {
        private readonly IEjeTematicoRepository repository;

        public EjeTamaticoService(IEjeTematicoRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
