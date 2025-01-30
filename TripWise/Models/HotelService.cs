using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    public class HotelService
    {
        [Key]
        public int HotelServiceId { get; set; }

        public int HotelId { get; set; }

        public int RoomTypeId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ServicePrice { get; set; }

        public bool Active { get; set; }

        public Hotel Hotel { get; set; }

        public RoomType RoomType { get; set; }
    }
}
