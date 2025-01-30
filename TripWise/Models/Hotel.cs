using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Hotels" , Schema = "Hotels and transport companies")]
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required, StringLength(100)]
        public string HotelName { get; set; }

        [Required, StringLength(255)]
        public string HotelAddress { get; set; }

        public string Details { get; set; }

        public bool IsPartner { get; set; }

        public bool Active { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public ICollection<HotelService> HotelServices { get; set; }
    }

}
