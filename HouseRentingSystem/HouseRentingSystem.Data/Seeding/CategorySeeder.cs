using HouseRentingSystem.Data.Entities;
using static HouseRentingSystem.Data.Seeding.SeedingConstants;

namespace HouseRentingSystem.Data.Seeding
{
    public static class CategorySeeder
    {
        public static ICollection<Category> SeedCategories()
        {
            return new List<Category>()
            {
                new Category
                {
                    Id = Guid.Parse(SeedingConstants.CottageCategoryId),
                    Name = "Cottage",
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
                new Category
                {
                    Id = Guid.Parse(SeedingConstants.SingleCategoryId),
                    Name = "Single",
                    CreatedOn = DateTime.Parse(CreatedOn)
                },
                new Category
                {
                    Id = Guid.Parse(SeedingConstants.DuplexCategoryId),
                    Name = "Duplex",
                    CreatedOn = DateTime.Parse(CreatedOn)
                }
            };
        }
    }
}
