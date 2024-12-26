namespace TripWise.Models
{
    public class TransportCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public int CityId { get; set; }
        public string HQAddress { get; set; } = null!;
        public int CompanyTypeId { get; set; }  
        public string? Description { get; set; }
        public bool IsPartner { get; set; }
        public bool Active { get; set; }
    }
}
