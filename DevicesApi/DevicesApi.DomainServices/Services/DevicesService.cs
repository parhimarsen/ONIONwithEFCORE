using DevicesApi.Domain.Interfaces;
using DevicesApi.Domain.Models;
using DevicesApi.DomainServices.Mappers;
using DevicesApi.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevicesApi.DomainServices.Services
{
    public class DevicesService : IDevicesService
    {
        private IUnitOfWork _unitOfWork;

        public DevicesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DomainDevice> SearchAllDevices()
        {
            var devices = _unitOfWork.DevicesRepository.GetDevices();

            return devices.Select(_ => _?.ToDomain()).ToList();
        }

        public DomainDevice SearchDevice(int deviceId)
        {
            return _unitOfWork.DevicesRepository.GetDevice(deviceId)?.ToDomain();
        }

        public void CreateDevice(DomainDevice device)
        {
            if (device == null)
                throw new ArgumentNullException();
            _unitOfWork.DevicesRepository.CreateDevice(device?.ToInfrastructure());
        }

        public void DeleteDevice(int deviceId)
        {
            _unitOfWork.DevicesRepository.DeleteDevice(deviceId);
        }
    }
}
