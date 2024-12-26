namespace TripWise.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string ContractCode { get; set; } = null!;
        public int CustomerId { get; set; }
        public int AgentId { get; set; }
        public DateTime TimeSigned { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
        public DateTime PaymentDate { get; set; } 
        public decimal PaymentAmount { get; set; }
        public bool Paid { get; set; }
        public DateTime RefundedTime { get; set; } 
        public decimal RefundedAmount { get; set; }
    }
}
