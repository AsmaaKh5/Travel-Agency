namespace TripWise.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; } = null!;
        public int CityId { get; set; }
        public string HotelAddress { get; set; } = null!;
        public string Details { get; set; } = null!;
        public bool IsPartner { get; set; }
        public bool Active { get; set; }

    }
}
