using HouseRentingSystem.Models.ViewModels.House;

namespace HouseRentingSystem.Web
{
    public class Common
    {
        public static IEnumerable<HouseDetailsViewModel> GetHouses()
        {
            return new List<HouseDetailsViewModel>()
            {
                new HouseDetailsViewModel()
                {
                    Title = "House 1",
                    Address = "Address 1",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRbcrj53mGyk-u4JwrIb6z1RBAeCpxR78gfQ&s"
                },
                new HouseDetailsViewModel()
                {
                    Title = "House 2",
                    Address = "Address 2",
                    ImageUrl = "https://images.surferseo.art/fdb08e2e-5d39-402c-ad0c-8a3293301d9e.png"
                },
                new HouseDetailsViewModel()
                {
                    Title = "House 3",
                    Address = "Address 3",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTotaTGSCjCbLZ6k9Rqqdcoqs-sUiUBwP36Zw&s"
                }
            };
        }
    }
}
