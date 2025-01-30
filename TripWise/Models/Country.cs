using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Countries", Schema = "Countries & cities")]
    public class Country
    {
        [Key]
        [StringLength(3)]

        public string CountryCode { get; set; }

        [Required, StringLength(100)]
        public string CountryName { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
