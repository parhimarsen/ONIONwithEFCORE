using DevicesApi.Domain.Models;
using DevicesApi.Models;

namespace DevicesApi.Mappers
{
    public static class DomainToUserModelMapper
    {
        public static UserModel ToModel(this DomainUser @this)
        {
            return new UserModel()
            {
                Name = @this.Name,
                Age = @this.Age,
                Role = @this.Role,
                Sex = @this.Sex
            };
        }
    }
}