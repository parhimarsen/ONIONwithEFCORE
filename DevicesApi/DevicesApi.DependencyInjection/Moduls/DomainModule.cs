using DevicesApi.Domain.Interfaces;
using DevicesApi.DomainServices.Services;
using Microsoft.Practices.Unity;

namespace DevicesApi.DependencyInjection.Moduls
{
    public class DomainModule : IModule
    {
        public void Registrate(IUnityContainer container)
        {
            container.RegisterType<IDevicesService, DevicesService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IUsersService, UsersService>(new ContainerControlledLifetimeManager());
        }
    }
}
