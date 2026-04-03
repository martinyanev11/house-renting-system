using HouseRentingSystem.Data.Entities;
using HouseRentingSystem.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configurations
{
    public class HouseEntityConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            // Fluent API configuration for the House entity

            builder
                .Property(h => h.PricePerMonth)
                .HasPrecision(18, 2);

            builder.HasData(HouseSeeder.SeedHouses());
        }
    }
}
