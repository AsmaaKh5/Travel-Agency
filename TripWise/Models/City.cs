using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required, StringLength(100)]
        public string CityName { get; set; }

        [Required, StringLength(3)]
        public string CountryCode { get; set; }

        public Country Country { get; set; }

        public ICollection<Hotel> Hotels { get; set; }

        public ICollection<TransportCompany> TransportCompanies { get; set; }
    }
}
