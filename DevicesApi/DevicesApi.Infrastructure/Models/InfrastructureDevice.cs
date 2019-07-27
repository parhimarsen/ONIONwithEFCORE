namespace DevicesApi.Infrastructure.Models
{
    public class InfrastructureDevice
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IdentificationNumber { get; set; }

        public InfrastructureUser User { get; set; }

        public int UserId { get; set; }
    }
}
