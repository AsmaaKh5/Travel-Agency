namespace TripWise.Models
{
    public class TransportService
    {
        public int Id { get; set; }
        public int TransportCompanyId { get; set; }
        public int TicketTypeId { get; set; }
        public int FromCityId { get; set; }
        public int ToCityId { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Active { get; set; }
    }
}
