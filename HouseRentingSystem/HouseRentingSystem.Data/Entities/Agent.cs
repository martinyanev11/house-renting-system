using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.Constants.Constants;

namespace HouseRentingSystem.Data.Entities
{
    public class Agent
    {
        public Agent()
        {
            Id = Guid.NewGuid();
            ManagedHouses = new HashSet<House>();
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
        }

        public Guid Id { get; init; }

        [Required]
        [MinLength(AgentPhoneNumberMinLength)]
        [MaxLength(AgentPhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public ICollection<House> ManagedHouses { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; }

        // Meta-data
        public DateTime CreatedOn { get; init; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
