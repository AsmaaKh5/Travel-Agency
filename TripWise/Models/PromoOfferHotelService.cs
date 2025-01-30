using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    [Table("PromoOfferHotelService" , Schema = "Offers and contracts")]
    public class PromoOfferHotelService
    {
        [Key]
        public int PromoOfferId { get; set; }

        public int HotelServiceId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int DiscountPercent { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalServicePrice { get; set; }

        public string Description { get; set; }

        public PromoOffer PromoOffer { get; set; }

        public HotelService HotelService { get; set; }
    }
}
