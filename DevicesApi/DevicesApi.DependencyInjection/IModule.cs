using Microsoft.Practices.Unity;

namespace DevicesApi.DependencyInjection.Moduls
{
    public interface IModule
    {
        void Registrate(IUnityContainer container);
    }
}
