namespace TripWise.Models
{
    public class OfferTransportService
    {
        public int Id { get; set; }
        public int TransportServiceId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal FinalServicePrice { get; set; }
        public string? Description { get; set; }

    }
}
