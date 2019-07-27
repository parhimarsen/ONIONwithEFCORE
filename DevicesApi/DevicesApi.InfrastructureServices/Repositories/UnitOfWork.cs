using DevicesApi.Infrastructure.Interfaces;
using DevicesApi.InfrastructureServices.Contexts;

namespace DevicesApi.InfrastructureServices.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private UsersRepository _usersRepository;
        private DevicesRepository _devicesRepository;
        private MyContext _context;

        public UnitOfWork(MyContext context)
        {
            _context = context;
        }

        public IUsersRepository UsersRepository
        {
            get
            {
                if (_usersRepository == null)
                    _usersRepository = new UsersRepository(_context);
                return _usersRepository;
            }
        }

        public IDevicesRepository DevicesRepository
        {
            get
            {
                if (_devicesRepository == null)
                    _devicesRepository = new DevicesRepository(_context);
                return _devicesRepository;
            }
        }
    }
}
