using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
  
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required, StringLength(100)]
        public string CityName { get; set; }

        [Required, StringLength(3)]
        public string CountryCode { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }

        public virtual ICollection<TransportCompany> TransportCompanies { get; set; }
    }
}
