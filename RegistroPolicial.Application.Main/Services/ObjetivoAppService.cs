using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Application.Main.Services
{
      public class ObjetivoAppService : BaseAppService<PAO_Objetivo>, IObjetivoAppService
    {
        //Declaración de variables globales
        private readonly IObjetivoService service;

        public ObjetivoAppService(IObjetivoService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
