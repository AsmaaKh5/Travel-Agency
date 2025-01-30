using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Offers" , Schema = "Offers and contracts")]
    public class Offer
    {
        [Key]
        public int OfferCode { get; set; }

        [Required, StringLength(100)]
        public string OfferName { get; set; }

        public DateTime TimeCreated { get; set; }

        public DateTime ActiveFrom { get; set; }

        public DateTime ActiveTo { get; set; }

        public DateTime? TimeAccepted { get; set; }

        public bool Accepted { get; set; }

        public int? PromoOfferId { get; set; }

        public int AgentId { get; set; }

        public int CustomerId { get; set; }

        public Agent Agent { get; set; }

        public Customer Customer { get; set; }

        public PromoOffer PromoOffer { get; set; }

        public ICollection<OfferHotelService> OfferHotelServices { get; set; }

        public ICollection<OfferTransportService> OfferTransportServices { get; set; }
    }
}
