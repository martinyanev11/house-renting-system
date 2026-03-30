using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.Constants.Constants;

namespace HouseRentingSystem.Data.Entities
{
    public class House
    {
        public House()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; init; }

        [Required]
        [MinLength(HouseTitleMinLength)]
        [MaxLength(HouseTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(HouseAddressMinLength)]
        [MaxLength(HouseAddressMaxLength)]
        public string Address { get; set; } = null!;

        [Required]
        [MinLength(HouseDescriptionMinLength)]
        [MaxLength(HouseDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(HousePricePerMonthMinValue, HousePricePerMonthMaxValue)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public Guid AgentID { get; set; }
        public Agent Agent { get; set; } = null!;

        [ForeignKey(nameof(Renter))]
        public Guid? RenterId { get; set; }
        public ApplicationUser? Renter { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; }

        // Meta-data
        public DateTime CreatedOn { get; init; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
