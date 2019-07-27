using DevicesApi.Domain.Interfaces;
using DevicesApi.Mappers;
using DevicesApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DevicesApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet, Route("")]
        public IEnumerable<UserModel> GetAllUsers()
        {
            return _usersService.SearchAllUsers()?.Select(_ => _?.ToModel()).ToList();
        }

        [HttpGet, Route("{userId}")]
        public UserModel GetUser(int userId)
        {
            return _usersService.SearchUser(userId)?.ToModel();
        }

        [HttpGet, Route("{userId}/devices")]
        public IEnumerable<DeviceModel> GetAllDevicesOfUser(int userId)
        {
            return _usersService.SearchAllDevicesOfUser(userId)?.Select(_ => _?.ToModel()).ToList();
        }

        [HttpGet, Route("{userId}/devices/{deviceId}")]
        public DeviceModel GetDeviceOfUser(int userId, int deviceId)
        {
            return _usersService.SearchDeviceOfUser(userId, deviceId)?.ToModel();
        }
    }
}
