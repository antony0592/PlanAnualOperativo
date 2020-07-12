using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;

namespace RegistroPolicial.Application.Main.Services
{
        public class MetaAppService : BaseAppService<PAO_Meta>, IMetaAppService
    {
        //Declaración de variables globales
        private readonly IMetaService service;

        public MetaAppService(IMetaService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
