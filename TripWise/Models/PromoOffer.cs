using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("PromoOffer" , Schema = "Offers and contracts")]
    public class PromoOffer
    {
        [Key]
        public int PromoOfferCode { get; set; }

        [Required, StringLength(100)]
        public string PromoOfferName { get; set; }

        [Required]
        public DateTime ActiveFrom { get; set; }

        [Required]
        public DateTime ActiveTo { get; set; }

        public ICollection<PromoOfferHotelService> PromoOfferHotelServices { get; set; }

        public ICollection<PromoOfferTransportService> PromoOfferTransportServices { get; set; }
    }

}
