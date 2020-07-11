using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Application.Main.Interfaces;

namespace RegistroPolicial.Application.Main.Services
{
    public class DelitoAppService : BaseAppService<Delito>, IDelitoAppService
    {        
        private readonly IDelitoService service;
        
        public DelitoAppService(IDelitoService service) :base(service)
        {
            this.service = service;
        }
    }
}