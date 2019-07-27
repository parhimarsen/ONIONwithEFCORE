using DevicesApi.Infrastructure.Interfaces;
using DevicesApi.Infrastructure.Models;
using DevicesApi.InfrastructureServices.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace DevicesApi.InfrastructureServices.Repositories
{
    public class DevicesRepository : IDevicesRepository
    {
        private MyContext _context;

        public DevicesRepository(MyContext context)
        {
            _context = context;
        }

        List<InfrastructureDevice> devices = new List<InfrastructureDevice>()
        {
            new InfrastructureDevice(){Id = 1, Name = "Phone", IdentificationNumber = 123, UserId = 1},
            new InfrastructureDevice(){Id = 2, Name = "Computer", IdentificationNumber = 555, UserId = 1}
        };
        public List<InfrastructureDevice> GetDevices()
        {
            return _context.Devices.ToList();
        }

        public InfrastructureDevice GetDevice(int deviceId)
        {
            return _context.Devices.FirstOrDefault(_ => _.Id == deviceId);
        }

        public IEnumerable<InfrastructureDevice> GetDevicesOfUser(int userId)
        {
            return _context.Devices.Where(_ => _.UserId == userId);
        }

        public InfrastructureDevice GetDeviceOfUser(int userId, int deviceId)
        {
            return GetDevicesOfUser(userId).FirstOrDefault(_ => _.Id == deviceId);
        }

        public void CreateDevice(InfrastructureDevice device)
        {
            device.Id = devices.Count + 1;
            _context.Devices.Add(device);
        }

        public void DeleteDevice(int deviceId)
        {
            InfrastructureDevice deleteDevice = GetDevice(deviceId);

            if (deleteDevice != null)
            {
                _context.Devices.Add(deleteDevice);
            }
        }
    }
}
