using HouseRentingSystem.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace HouseRentingSystem.Data.Seeding
{
    public static class UserSeeder
    {
        public static ICollection<ApplicationUser> SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            string defaultPassword = "123456";

            List< ApplicationUser> users =  new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = Guid.Parse(SeedingConstants.FirstUserId),
                    UserName = SeedingConstants.FirstUserEmail,
                    NormalizedUserName = SeedingConstants.FirstUserEmail.ToUpper(),
                    Email = SeedingConstants.FirstUserEmail,
                    NormalizedEmail = SeedingConstants.FirstUserEmail.ToUpper(),
                    AgentId = Guid.Parse(SeedingConstants.FirstAgentId),
                    CreatedOn = DateTime.Parse(SeedingConstants.CreatedOn),
                    EmailConfirmed = true,
                    ConcurrencyStamp = SeedingConstants.FirstUserConcurrencyStamp,
                    SecurityStamp = SeedingConstants.FirstUserSecurityStamp,
                    PhoneNumber = SeedingConstants.FirstUserPhone,
                },
                new ApplicationUser()
                {
                    Id = Guid.Parse(SeedingConstants.SecondUserId),
                    UserName = SeedingConstants.SecondUserEmail,
                    NormalizedUserName = SeedingConstants.SecondUserEmail.ToUpper(),
                    Email = SeedingConstants.SecondUserEmail,
                    NormalizedEmail = SeedingConstants.SecondUserEmail.ToUpper(),
                    AgentId = Guid.Parse(SeedingConstants.SecondAgentId),
                    CreatedOn = DateTime.Parse(SeedingConstants.CreatedOn),
                    EmailConfirmed = true,
                    ConcurrencyStamp = SeedingConstants.SecondUserConcurrencyStamp,
                    SecurityStamp = SeedingConstants.SecondUserSecurityStamp,
                    PhoneNumber = SeedingConstants.SecondUserPhone,
                },
                new ApplicationUser()
                {
                    Id = Guid.Parse(SeedingConstants.ThirdUserId),
                    UserName = SeedingConstants.ThirdUserEmail,
                    NormalizedUserName = SeedingConstants.ThirdUserEmail.ToUpper(),
                    Email = SeedingConstants.ThirdUserEmail,
                    NormalizedEmail = SeedingConstants.ThirdUserEmail.ToUpper(),
                    CreatedOn = DateTime.Parse(SeedingConstants.CreatedOn),
                    EmailConfirmed = true,
                    ConcurrencyStamp = SeedingConstants.ThirdUserConcurrencyStamp,
                    SecurityStamp = SeedingConstants.ThirdUserSecurityStamp,
                    PhoneNumber = SeedingConstants.ThirdUserPhone,
                },
            };

            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, defaultPassword);
            }

            return users;
        }
    }
}
