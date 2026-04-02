using HouseRentingSystem.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<House>()
                .Property(h => h.PricePerMonth)
                .HasPrecision(18, 2);
        }
    }
}
