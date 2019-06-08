[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TouristAgency.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(TouristAgency.App_Start.NinjectWebCommon), "Stop")]

namespace TouristAgency.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using AutoMapper;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;
    using TouristAgency.Data.Repositories;
    using TouristAgency.Services;

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
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                kernel.Load(new AutoMapperNinjectModule());
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
            // Repositories
            kernel.Bind<IUserAccountRepository>().To<UserAccountRepository>();
            kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            kernel.Bind<IFeatureRepository>().To<FeatureRepository>();
            kernel.Bind<IHotelRepository>().To<HotelRepository>();
            kernel.Bind<IPrivilegeRepository>().To<PrivilegeRepository>();
            kernel.Bind<IRoleRepository>().To<RoleRepository>();
            kernel.Bind<ITouristRepository>().To<TouristRepository>();
            kernel.Bind<ITourRepository>().To<TourRepository>();
            kernel.Bind<ITourTypeRepository>().To<TourTypeRepository>();

            // Services
            kernel.Bind<IUserAccountService>().To<UserAccountService>();
            kernel.Bind<IEmployeeService>().To<EmployeeService>();
            kernel.Bind<IFeatureService>().To<FeatureService>();
            kernel.Bind<IHotelService>().To<HotelService>();
            kernel.Bind<IPrivilegeService>().To<PrivilegeService>();
            kernel.Bind<IRoleService>().To<RoleService>();
            kernel.Bind<ITouristService>().To<TouristService>();
            kernel.Bind<ITourService>().To<TourService>();
            kernel.Bind<ITourTypeService>().To<TourTypeService>();
        }        
    }
}