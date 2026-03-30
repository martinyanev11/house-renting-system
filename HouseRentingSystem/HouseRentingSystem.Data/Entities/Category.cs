using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.Constants.Constants;

namespace HouseRentingSystem.Data.Entities
{
    public class Category
    {
        public Category()
        {
            Id = Guid.NewGuid();
            Houses = new HashSet<House>();
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; init; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<House> Houses { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; }

        // Meta-data
        public DateTime CreatedOn { get; init; }
        public DateTime LastUpdatedOn { get; set; }
    }
}
