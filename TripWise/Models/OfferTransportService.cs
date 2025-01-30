using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    [Table("OfferTransportService" , Schema = "Offers and contracts")]
    public class OfferTransportService
    {
        [Key]
        public int OfferCode { get; set; }

        public int TransportServiceId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int DiscountPercent { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FinalServicePrice { get; set; }

        public string Description { get; set; }

        public Offer Offer { get; set; }

        public TransportService TransportService { get; set; }
    }
}
