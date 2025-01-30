using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    [Table("TransportCompany" , Schema = "Hotels and transport companies")]
    public class TransportCompany
    {
        [Key]
        public int CompanyId { get; set; }

        [Required, StringLength(100)]
        public string CompanyName { get; set; }

        [Required, StringLength(255)]
        public string HQAddress { get; set; }

        public string Description { get; set; }

        public bool IsPartner { get; set; }

        public bool Active { get; set; }

        public int CityId { get; set; }

        public int CompanyTypeId { get; set; }

        public City City { get; set; }

        public CompanyType CompanyType { get; set; }

        public ICollection<TransportService> TransportServices { get; set; }
    }
}
