namespace TripWise.Models
{
    public class PromoOfferHotelService
    {
        public int Id { get; set; }
        public int PromoOfferId { get; set; }
        public int HotelServiceId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal FinalServicePrice { get; set; }
        public string? Description { get; set; }
    }
}
