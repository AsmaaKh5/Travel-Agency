namespace TripWise.Models
{
    public class OfferHotelService
    {
        public int Id { get; set; }
        public int HotelServiceId { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal FinalServicePrice { get; set; }
        public string? Description { get; set; }
    }
}
