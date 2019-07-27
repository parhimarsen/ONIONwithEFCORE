using DevicesApi.Infrastructure.Models;
using System.Collections.Generic;

namespace DevicesApi.Infrastructure.Interfaces
{
    public interface IDevicesRepository
    {
        List<InfrastructureDevice> GetDevices();

        InfrastructureDevice GetDevice(int deviceId);

        IEnumerable<InfrastructureDevice> GetDevicesOfUser(int userId);

        InfrastructureDevice GetDeviceOfUser(int userId, int deviceId);

        void CreateDevice(InfrastructureDevice device);

        void DeleteDevice(int deviceId);
    }
}
