using DevicesApi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevicesApi.InfrastructureServices.Configurations
{
    public class DevicesConfiguration : IEntityTypeConfiguration<InfrastructureDevice>
    {
        public void Configure(EntityTypeBuilder<InfrastructureDevice> builder)
        {
            builder.ToTable("Devices");
            builder.HasKey(_ => _.Id);
        }
    }
}
