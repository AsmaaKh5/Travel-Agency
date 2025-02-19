﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripWise.Models
{
   
    public class TransportService
    {
        [Key]
        public int TransportServiceId { get; set; }

        public int TransportCompanyId { get; set; }

        public int TicketTypeId { get; set; }

        public int FromCityId { get; set; }

        public int ToCityId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ServicePrice { get; set; }

        public bool Active { get; set; }

        public virtual TransportCompany TransportCompany { get; set; }

        public virtual TicketType TicketType { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

        public virtual ICollection<PromoOfferTransportService> PromoOffers { get; set; }

        public virtual ICollection<OfferTransportService> Offers { get; set; }
    }

}
