using DevicesApi.Infrastructure.Interfaces;
using DevicesApi.InfrastructureServices.Contexts;
using DevicesApi.InfrastructureServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using System.Configuration;

namespace DevicesApi.DependencyInjection.Moduls
{
    public class InfrastructureModule : IModule
    {
        public void Registrate(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DevicesApiDb"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();

            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));

            container.RegisterType<IDevicesRepository, DevicesRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IUsersRepository, UsersRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager());
        }
    }
}
