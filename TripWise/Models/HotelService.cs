namespace TripWise.Models
{
    public class HotelService
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Active { get; set; }
    }
}
