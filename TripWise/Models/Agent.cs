using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Agents" , Schema = "Customers and agents")]
    public class Agent
    {
        [Key]
        public int AgentCode { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        public bool Active { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
