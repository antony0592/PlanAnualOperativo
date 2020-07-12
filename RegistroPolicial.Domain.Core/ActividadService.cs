using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Interfaces.Repositories;

namespace RegistroPolicial.Domain.Core
{
    public class ActividadService : BaseService<PAO_Actividad>, IActividadService
    {
        private readonly IActividadRepository repository;

        public ActividadService(IActividadRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
