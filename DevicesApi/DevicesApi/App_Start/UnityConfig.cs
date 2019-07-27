using DevicesApi.DependencyInjection.Moduls;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace DevicesApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            Registrate<DomainModule>(container);
            Registrate<InfrastructureModule>(container);
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Registrate<T>(IUnityContainer container) where T : IModule, new()
        {
            new T().Registrate(container);
        }
    }
}