using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("TicketType", Schema = "Hotels and transport companies")]
    public class TicketType
    {
        [Key]
        public int TicketTypeId { get; set; }

        [Required, StringLength(100)]
        public string TypeName { get; set; }

        public ICollection<TransportService> TransportServices { get; set; }
    }
}
