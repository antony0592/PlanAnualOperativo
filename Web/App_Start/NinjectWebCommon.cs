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
            //Servicios de la capa de aplicación Base
            kernel.Bind(typeof(IBaseAppService<>)).To(typeof(BaseAppService<>));
            //Servicios de la capa de aplicación Entities
            kernel.Bind<IEjeTematicoAppService>().To<EjeTematicoAppService>();
            kernel.Bind<IObjetivoAppService>().To<ObjetivoAppService>();
            kernel.Bind<IMetaAppService>().To<MetaAppService>();
            kernel.Bind<IAvanceAppService>().To<AvanceAppService>();
            kernel.Bind<IActividadAppService>().To<ActividadAppService>();
            kernel.Bind<ICoordinacionAppService>().To<CoordinacionAppService>();

            //Servicios de la capa de aplicación con servicios de dominio base
            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<>));
            //Servicios de la capa de aplicación con servicios de dominio Entities
            kernel.Bind<IEjeTematicoService>().To<EjeTematicoAppService>();
            kernel.Bind<IObjetivoService>().To<ObjetivoAppService>();
            kernel.Bind<IMetaService>().To<MetaAppService>();
            kernel.Bind<IAvanceService>().To<AvanceAppService>();
            kernel.Bind<IActividadService>().To<ActividadAppService>();
            kernel.Bind<ICoordinacionService>().To<CoordinacionAppService>();


            //Repositorio del dominio a los de infraestructura Base
            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            //Repositorio del dominio a los de infraestructura Base
            kernel.Bind<IEjeTematicoRepository>().To<EjeTematicoRepository>();
            kernel.Bind<IObjetivoRepository>().To<ObjetivoRepository>();
            kernel.Bind<IMetaRepository>().To<MetaRepository>();
            kernel.Bind<IAvanceRepository>().To<AvanceRepository>();
            kernel.Bind<IActividadRepository>().To<ActividadRepository>();
            kernel.Bind<ICoordinacionRepository>().To<CoordinacionRepository>();
        }
    }
}
