using DevicesApi.Infrastructure.Models;
using DevicesApi.InfrastructureServices.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DevicesApi.InfrastructureServices.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public virtual DbSet<InfrastructureUser> Users { get; set; }
        public virtual DbSet<InfrastructureDevice> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new UsersConfiguration()));
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new DevicesConfiguration()));
        }
    }
}
