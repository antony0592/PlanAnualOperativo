using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Application.Main.Services
{
      public class CoordinacionAppService : BaseAppService<PAO_Coordinacion>, ICoordinacionAppService
    {
        private readonly ICoordinacionService service;

        public CoordinacionAppService(ICoordinacionService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
