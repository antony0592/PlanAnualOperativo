using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Domain.Interfaces.Repositories;


namespace RegistroPolicial.Domain.Core
{
    public class ObjetivoService:BaseService<PAO_Objetivo>,IObjetivoService
    {
        private readonly IObjetivoRepository repository;

        public ObjetivoService(IObjetivoRepository repository) : base(repository)
        {
            this.repository = repository;
        }//Fin del método
    }
}
