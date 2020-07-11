[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Web.App_Start.NinjectWebCommon), "Stop")]

namespace Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using RegistroPolicial.Application.Main.Interfaces;
    using RegistroPolicial.Application.Main.Services;
    using RegistroPolicial.Domain.Interfaces.Services;
    using RegistroPolicial.Domain.Core;
    using RegistroPolicial.Domain.Interfaces.Repositories;
    using RegistroPolicial.Infraestructure.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //Servicios de la capa de aplicaci�n
            kernel.Bind(typeof(IBaseAppService<>)).To(typeof(BaseAppService<>));
            kernel.Bind<IDelitoAppService>().To<DelitoAppService>();
            kernel.Bind<IPersonaJuridicaAppService>().To<PersonaJuridicaAppService>();
            kernel.Bind<IDelitoPersonaJuridicaAppService>().To<DelitoPersonaJuridicaAppService>();

            //Servicios de la capa de aplicaci�n con servicios de dominio
            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<>));
            kernel.Bind<IDelitoService>().To<DelitoService>();
            kernel.Bind<IPersonaJuridicaService>().To<PersonaJuridicaService>();
            kernel.Bind<IDelitoPersonaJuridicaService>().To<DelitoPersonaJuridicaService>();

            //Repositorio del dominio a los de infraestructura
            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind<IDelitoRepository>().To<DelitoRepository>();
            kernel.Bind<IPersonaJuridicaRepository>().To<PersonaJuridicaRepository>();
            kernel.Bind<IDelitoPersonaJuridicaRepository>().To<DelitoPersonaJuridicaRepository>();
        }
    }
}
