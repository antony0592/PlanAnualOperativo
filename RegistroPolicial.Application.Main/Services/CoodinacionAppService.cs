using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;



namespace RegistroPolicial.Application.Main.Services
{
      public class CoodinacionAppService : BaseAppService<PAO_Coordinacion>, ICoordinacionAppService
    {
        //Declaración de variables globales
        private readonly ICoordinacionService service;

        public CoodinacionAppService(ICoordinacionService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
