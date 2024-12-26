namespace TripWise.Models
{
    public class PromoOffer
    {
        public int Id { get; set; }
        public string PromoOfferCode { get; set; } = null!;
        public string PromoOfferName { get; set; } = null!;
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
    }
}
