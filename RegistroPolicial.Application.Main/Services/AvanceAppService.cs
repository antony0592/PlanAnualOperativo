using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;
using RegistroPolicial.Application.Main.Interfaces;

namespace RegistroPolicial.Application.Main.Services
{
    public class AvanceAppService:BaseAppService<PAO_Avance>,IAvanceAppService
    {
        //Declaración de variables globales
        private readonly IAvanceService service;

       public AvanceAppService(IAvanceService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
