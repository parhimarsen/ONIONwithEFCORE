using DevicesApi.Domain.Models;
using DevicesApi.Models;

namespace DevicesApi.Mappers
{
    public static class DeviceModelToDomainMapper
    {
        public static DomainDevice ToInfrastructure(this DeviceModel @this)
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