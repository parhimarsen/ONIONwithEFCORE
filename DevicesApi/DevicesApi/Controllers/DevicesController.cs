using DevicesApi.Domain.Interfaces;
using DevicesApi.Mappers;
using DevicesApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DevicesApi.Controllers
{
    [RoutePrefix("api/devices")]
    public class DevicesController : ApiController
    {
        private IDevicesService _devicesService;

        public DevicesController(IDevicesService devicesService)
        {
            _devicesService = devicesService;
        }

        [HttpGet, Route("")]
        public IEnumerable<DeviceModel> GetAllDevices()
        {
            return _devicesService.SearchAllDevices().Select(_ => _?.ToModel()).ToList();
        }

        [HttpGet, Route("{deviceId}")]
        public DeviceModel GetDevice(int deviceId)
        {
            return _devicesService.SearchDevice(deviceId)?.ToModel();
        }

        [HttpPost, Route("create")]
        public void CreateDevice(DeviceModel device)
        {
            _devicesService.CreateDevice(device?.ToInfrastructure());
        }

        [HttpPost, Route("delete")]
        public void DeleteDevice(int deviceId)
        {
            _devicesService.DeleteDevice(deviceId);
        }

    }
}
