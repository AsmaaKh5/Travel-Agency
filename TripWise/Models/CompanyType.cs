using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
    [Table("CompanyTypes", Schema = "Hotels and transport companies")]
    public class CompanyType
    {
        [Key]
        public int CompanyTypeId { get; set; }

        [Required, StringLength(100)]
        public string TypeName { get; set; }

        public ICollection<TransportCompany> TransportCompanies { get; set; }
    }
}
