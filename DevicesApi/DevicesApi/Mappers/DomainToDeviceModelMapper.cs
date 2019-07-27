using DevicesApi.Domain.Models;
using DevicesApi.Models;

namespace DevicesApi.Mappers
{
    public static class DomainToDeviceModelMapper
    {
        public static DeviceModel ToModel(this DomainDevice @this)
        {
            return new DeviceModel()
            {
                Name = @this.Name,
                IdentificationNumber = @this.IdentificationNumber,
                UserId = @this.UserId
            };
        }
    }
}