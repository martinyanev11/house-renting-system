using Microsoft.AspNetCore.Identity;

namespace HouseRentingSystem.Data.Entities
{
    /// <summary>
    /// Extending the IdentityUser class with a custom ApplicationUser class allows us to add additional properties and functionality specific to our application's needs, while still leveraging the built-in features of ASP.NET Core Identity for user management and authentication.
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            RentedHouses = new HashSet<House>();
            IsDeleted = false;
        }

        public Guid? AgentId { get; set; }
        public Agent? Agent { get; set; }

        public ICollection<House> RentedHouses { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; }

        // Meta-data
        public DateTime CreatedOn { get; init; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
