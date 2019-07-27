using DevicesApi.Domain.Models;
using System.Collections.Generic;

namespace DevicesApi.Domain.Interfaces
{
    public interface IDevicesService
    {
        List<DomainDevice> SearchAllDevices();

        DomainDevice SearchDevice(int deviceId);

        void CreateDevice(DomainDevice device);

        void DeleteDevice(int deviceId);
    }
}
