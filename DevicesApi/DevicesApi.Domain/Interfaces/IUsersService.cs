using DevicesApi.Domain.Models;
using System.Collections.Generic;

namespace DevicesApi.Domain.Interfaces
{
    public interface IUsersService
    {
        List<DomainUser> SearchAllUsers();

        DomainUser SearchUser(int userId);

        List<DomainDevice> SearchAllDevicesOfUser(int usersId);

        DomainDevice SearchDeviceOfUser(int userId, int deviceId);
    }
}
