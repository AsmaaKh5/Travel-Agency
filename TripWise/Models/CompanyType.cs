using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{

    public class CompanyType
    {
        [Key]
        public int CompanyTypeId { get; set; }

        [Required, StringLength(100)]
        public string TypeName { get; set; }

        public virtual ICollection<TransportCompany> TransportCompanies { get; set; }
    }
}
