using Ninject.Web.Common;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency.Data
{
    /// <summary>
    /// Holds Ninject configuration for EF infrastructure
    /// </summary>
    class EFConfiguration
    {
        private readonly IKernel _kernel;

        public EFConfiguration(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Configure()
        {
            // Bind application context for other components in this assembly
            _kernel.Bind<DataModel>().ToSelf().InRequestScope();

            // Bind queriable repositories for read queries

            _kernel.Bind<Repositories.IEmployeeRepository>().To<Repositories.EmployeeRepository>().InRequestScope();
            _kernel.Bind<Repositories.IFeatureRepository>().To<Repositories.FeatureRepository>().InRequestScope();
            _kernel.Bind<Repositories.IHotelRepository>().To<Repositories.HotelRepository>().InRequestScope();
            _kernel.Bind<Repositories.IPrivilegeRepository>().To<Repositories.PrivilegeRepository>().InRequestScope();
            _kernel.Bind<Repositories.IRoleRepository>().To<Repositories.RoleRepository>().InRequestScope();
            _kernel.Bind<Repositories.ITouristRepository>().To<Repositories.TouristRepository>().InRequestScope();
            _kernel.Bind<Repositories.ITourRepository>().To<Repositories.TourRepository>().InRequestScope();
            _kernel.Bind<Repositories.ITourTypeRepository>().To<Repositories.TourTypeRepository>().InRequestScope();
            _kernel.Bind<Repositories.IUserRepository>().To<Repositories.UserRepository>().InRequestScope();
        }
    }
}
