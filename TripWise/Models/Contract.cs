﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripWise.Models
{
    [Table("Contract" , Schema = "Offers and contracts")]
    public class Contract
    {
        [Key]
        public int ContractCode { get; set; }

        public int CustomerId { get; set; }

        public int AgentId { get; set; }

        public int OfferCode { get; set; }

        public DateTime TimeSigned { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PaymentAmount { get; set; }

        public bool Refunded { get; set; }

        public DateTime? RefundedTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? RefundedAmount { get; set; }

        public Customer Customer { get; set; }

        public Agent Agent { get; set; }

        public Offer Offer { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }

}
