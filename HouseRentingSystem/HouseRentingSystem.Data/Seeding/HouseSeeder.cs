using HouseRentingSystem.Data.Entities;
using static HouseRentingSystem.Data.Seeding.SeedingConstants;

namespace HouseRentingSystem.Data.Seeding
{
    public static class HouseSeeder
    {
        public static ICollection<House> SeedHouses()
        {
            return new List<House>()
            {
                new House
                {
                    Id = Guid.Parse(FirstHouseId),
                    Title = "Cozy Apartment in the City Center",
                    Address = "123 Main Street, Cityville",
                    Description = "A cozy apartment located in the heart of the city. Close to shops and public transportation.",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGS-nS14Fm9zhEQegRDRIkYUlhivdaJDNUeg&s",
                    PricePerMonth = 1200.00m,
                    CategoryId = Guid.Parse(CottageCategoryId),
                    AgentId = Guid.Parse(FirstAgentId),
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
                new House
                {
                    Id = Guid.Parse(SecondHouseId),
                    Title = "House Example",
                    Address = "123 Apple Street, Cityville",
                    Description = "Close to shops and public transportation.",
                    ImageUrl = "https://t4.ftcdn.net/jpg/00/00/64/91/360_F_649185_MwxGCma1gdvNStLmi1pGLnEg7QrJkC.jpg",
                    PricePerMonth = 3400.00m,
                    CategoryId = Guid.Parse(SingleCategoryId),
                    AgentId = Guid.Parse(FirstAgentId),
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
                new House
                {
                    Id = Guid.Parse(ThirdHouseID),
                    Title = "House 3",
                    Address = "Mladost 3, Sofia",
                    Description = "Qko",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSKpvCqGI4-FgKWCPAxdF_RW3t7fvfoJksAww&s",
                    PricePerMonth = 9400.00m,
                    CategoryId = Guid.Parse(DuplexCategoryId),
                    AgentId = Guid.Parse(SecondAgentId),
                    CreatedOn = DateTime.Parse(CreatedOn)
                } 
            };
        } 
    }
}
