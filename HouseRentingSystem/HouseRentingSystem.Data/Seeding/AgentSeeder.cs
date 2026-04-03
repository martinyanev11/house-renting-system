using HouseRentingSystem.Data.Entities;
using static HouseRentingSystem.Data.Seeding.SeedingConstants;

namespace HouseRentingSystem.Data.Seeding
{
    public static class AgentSeeder
    {
        public static ICollection<Agent> SeedAgents()
        {
            return new List<Agent>()
            {
                new Agent
                {
                    Id = Guid.Parse(SeedingConstants.FirstAgentId),
                    PhoneNumber = "+359888888888",
                    UserId = Guid.Parse(SeedingConstants.FirstUserId),
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
                new Agent
                {
                    Id = Guid.Parse(SeedingConstants.SecondAgentId),
                    PhoneNumber = "+359999999999",
                    UserId = Guid.Parse(SeedingConstants.SecondUserId),
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
            };
        }
    }
}
