using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TripWise.Models;

namespace TripWise
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TransportCompany> TransportCompanies { get; set; }
        public DbSet<TransportService> TransportServices { get; set; }
        public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<PromoOffer> PromoOffers { get; set; }
        public DbSet<PromoOfferHotelService> PromoOfferHotelServices { get; set; }
        public DbSet<PromoOfferTransportService> PromoOfferTransportServices { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferHotelService> OfferHotelServices { get; set; }
        public DbSet<OfferTransportService> OfferTransportServices { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country").HasKey(c => c.CountryCode);
            modelBuilder.Entity<City>().ToTable("City").HasOne(c => c.Country).WithMany(c => c.Cities).HasForeignKey(c => c.CountryCode);
            modelBuilder.Entity<Hotel>().ToTable("Hotel").HasOne(h => h.City).WithMany(c => c.Hotels).HasForeignKey(h => h.CityId);
            modelBuilder.Entity<TransportCompany>().ToTable("Transport_Company").HasOne(tc => tc.City).WithMany(c => c.TransportCompanies).HasForeignKey(tc => tc.CityId);
            modelBuilder.Entity<TransportCompany>().HasOne(tc => tc.CompanyType).WithMany(ct => ct.TransportCompanies).HasForeignKey(tc => tc.CompanyTypeId);
            modelBuilder.Entity<TransportService>().ToTable("Transport_Service").HasOne(ts => ts.TransportCompany).WithMany(tc => tc.TransportServices).HasForeignKey(ts => ts.TransportCompanyId);
            modelBuilder.Entity<TransportService>().HasOne(ts => ts.TicketType).WithMany(tt => tt.TransportServices).HasForeignKey(ts => ts.TicketTypeId);
            modelBuilder.Entity<HotelService>().ToTable("Hotel_Service").HasOne(hs => hs.Hotel).WithMany(h => h.HotelServices).HasForeignKey(hs => hs.HotelId);
            modelBuilder.Entity<HotelService>().HasOne(hs => hs.RoomType).WithMany(rt => rt.HotelServices).HasForeignKey(hs => hs.RoomTypeId);
        }
    }
}
