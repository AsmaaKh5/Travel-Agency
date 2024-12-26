namespace TripWise.Models
{
    public class PromoOfferTransportService
    {
        public int Id { get; set; }
        public int PromoOfferId { get; set; }
        public int TransportServiceId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal FinalServicePrice { get; set; }
        public string? Description { get; set; }
    }
}
