using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    [Table("OfferHotelService" , Schema = "Offers and contracts")]
    public class OfferHotelService
    {
        [Key]
        public int OfferCode { get; set; }

        public int HotelServiceId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int DiscountPercent { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalServicePrice { get; set; }

        public string Description { get; set; }

        public Offer Offer { get; set; }

        public HotelService HotelService { get; set; }
    }

}
