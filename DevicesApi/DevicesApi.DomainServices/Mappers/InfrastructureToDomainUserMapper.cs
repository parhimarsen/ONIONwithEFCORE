using DevicesApi.Domain.Models;
using DevicesApi.Infrastructure.Models;

namespace DevicesApi.DomainServices.Mappers
{
    public static class InfrastructureToDomainUserMapper
    {
        public static DomainUser ToDomain(this InfrastructureUser @this)
        {
            return new DomainUser()
            {
                Name = @this.Name,
                Age = @this.Age,
                Role = @this.Role,
                Sex = @this.Sex
            };
        }
    }
}
