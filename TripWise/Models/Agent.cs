using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
   
    public class Agent
    {
        [Key]
        public int AgentCode { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        public bool Active { get; set; }

        public virtual ICollection<PromoOffer> PromoOffers { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
