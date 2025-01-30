using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("Customers", Schema = "Customers and agents")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public string Details { get; set; }

        public DateTime CustomerFrom { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
