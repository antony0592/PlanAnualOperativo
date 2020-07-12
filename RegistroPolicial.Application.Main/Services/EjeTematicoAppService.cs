using RegistroPolicial.Application.Main.Interfaces;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Services;


namespace RegistroPolicial.Application.Main.Services
{
        public class EjeTematicoAppService : BaseAppService<PAO_EjeTematico>, IEjeTematicoAppService
    {
        //Declaración de variables globales
        private readonly IEjeTematicoService service;

        public EjeTematicoAppService(IEjeTematicoService service) : base(service)
        {
            this.service = service;
        }//Fin del método
    }
}
