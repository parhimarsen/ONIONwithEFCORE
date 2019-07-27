using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevicesApi.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IUsersRepository UsersRepository { get; }

        IDevicesRepository DevicesRepository { get; }
    }
}
