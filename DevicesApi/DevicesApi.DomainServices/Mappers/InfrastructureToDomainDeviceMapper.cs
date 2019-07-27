using DevicesApi.Domain.Models;
using DevicesApi.Infrastructure.Models;

namespace DevicesApi.DomainServices.Mappers
{
    public static class InfrastructureToDomainDeviceMapper
    {
        public static DomainDevice ToDomain(this InfrastructureDevice @this)
        {
            return new DomainDevice()
            {
                Name = @this.Name,
                IdentificationNumber = @this.IdentificationNumber,
                UserId = @this.UserId
            };
        }
    }
}
