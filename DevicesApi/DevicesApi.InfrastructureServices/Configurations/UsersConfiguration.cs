using DevicesApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevicesApi.InfrastructureServices.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<InfrastructureUser>
    {
        public void Configure(EntityTypeBuilder<InfrastructureUser> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(_ => _.Id);
        }
    }
}
