using DevicesApi.Infrastructure.Models;
using System.Collections.Generic;

namespace DevicesApi.Infrastructure.Interfaces
{
    public interface IUsersRepository
    {
        List<InfrastructureUser> GetUsers();

        InfrastructureUser GetUser(int userId);
    }
}
