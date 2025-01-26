using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheClubGymproject.Model
{
    public class TheclubGymcontext :DbContext
    {
        public DbSet<classes> Classes { get; set; }
        public DbSet<trainers> trainers { get; set; }
        public DbSet<members> Members { get; set; }
        public DbSet<payment> Payments { get; set; }
        public DbSet<offer> Offers { get; set; }
        public DbSet<membership> Memberships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-g152cko;Database=TheClubGym;Trusted_Connection=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the relationships explicitly (if needed)
            modelBuilder.Entity<membership>()
                .HasOne(m => m.Member) // A membership has one member
                .WithMany() // A member can have many memberships
                .HasForeignKey(m => m.MemberId);

            modelBuilder.Entity<membership>()
                .HasOne(m => m.Offer) // A membership has one offer
                .WithMany() // An offer can be associated with many memberships
                .HasForeignKey(m => m.OfferId);
        }
    }
}
