using DevicesApi.Domain.Interfaces;
using DevicesApi.Domain.Models;
using DevicesApi.DomainServices.Mappers;
using DevicesApi.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevicesApi.DomainServices.Services
{
    public class UsersService : IUsersService
    {
        private IUnitOfWork _unitOfWork;

        public UsersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DomainUser> SearchAllUsers()
        {
            var users = _unitOfWork.UsersRepository.GetUsers();

            return users.Select(_ => _?.ToDomain()).ToList();
        }

        public DomainUser SearchUser(int userId)
        {
            return _unitOfWork.UsersRepository.GetUser(userId)?.ToDomain();
        }

        public List<DomainDevice> SearchAllDevicesOfUser(int userId)
        {
            var users = _unitOfWork.DevicesRepository.GetDevicesOfUser(userId);

            return users.Select(_ => _?.ToDomain()).ToList();
        }

        public DomainDevice SearchDeviceOfUser(int userId, int deviceId)
        {
            return _unitOfWork.DevicesRepository.GetDeviceOfUser(userId, deviceId)?.ToDomain();
        }
    }
}
