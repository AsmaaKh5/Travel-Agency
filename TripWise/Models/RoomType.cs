using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("RoomTypes" , Schema = "Hotels and transport companies")]
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Required, StringLength(100)]
        public string TypeName { get; set; }

        public ICollection<HotelService> HotelServices { get; set; }
    }
}
