namespace TripWise.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public string AgentCode { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool Active { get; set; }
    }
}
