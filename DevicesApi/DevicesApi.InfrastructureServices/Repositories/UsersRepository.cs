using DevicesApi.Infrastructure.Interfaces;
using DevicesApi.Infrastructure.Models;
using DevicesApi.InfrastructureServices.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace DevicesApi.InfrastructureServices.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private MyContext _context;

        public UsersRepository(MyContext context)
        {
            _context = context;
        }

        private List<InfrastructureUser> users = new List<InfrastructureUser>()
        {
            new InfrastructureUser() {Id = 1, Age = 20, Name = "Arseny", Role = "User", Sex = "Male"}
        };

        public List<InfrastructureUser> GetUsers()
        {
            return _context.Users.ToList();
        }

        public InfrastructureUser GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(_ => _.Id == userId);
        }
    }
}
