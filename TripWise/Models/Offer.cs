namespace TripWise.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string OfferCode { get; set; } = null!;
        public string OfferName { get; set; } = null!;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }
        public bool Accepted { get; set; }
        public DateTime TimeAccepted { get; set; }
        public int PromoOfferId { get; set; }
        public int AgentId { get; set; }
        public int CustomerId { get; set; }
    }
}
