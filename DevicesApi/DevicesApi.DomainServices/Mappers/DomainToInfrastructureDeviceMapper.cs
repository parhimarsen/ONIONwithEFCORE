using DevicesApi.Domain.Models;
using DevicesApi.Infrastructure.Models;

namespace DevicesApi.DomainServices.Mappers
{
    public static class DomainToInfrastructureDeviceMapper
    {
        public static InfrastructureDevice ToInfrastructure(this DomainDevice @this)
        {
            return new InfrastructureDevice()
            {
                Name = @this.Name,
                IdentificationNumber = @this.IdentificationNumber,
                UserId = @this.UserId
            };
        }
    }
}
