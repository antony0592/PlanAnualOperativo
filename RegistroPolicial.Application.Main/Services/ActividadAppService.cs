using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;


namespace RegistroPolicial.Application.Main.Services
{
    public class ActividadAppService : BaseAppService<PAO_Actividad>, IActividadAppService
    {
        //Declaración de variables globales
        private readonly IActividadService service;

        public ActividadAppService(IActividadService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
