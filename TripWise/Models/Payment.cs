using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int ContractCode { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentAmount { get; set; }

        public Contract Contract { get; set; }
    }
}
