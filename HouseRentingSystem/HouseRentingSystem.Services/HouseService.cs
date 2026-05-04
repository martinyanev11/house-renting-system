using HouseRentingSystem.Models.ViewModels.House;
using HouseRentingSystem.Services.Contracts;

namespace HouseRentingSystem.Services
{
    public class HouseService : IHouseService
    {
        public AllHousesViewModel GetHouses()
        {
            var model = new AllHousesViewModel()
            {
                Houses = new List<HouseDetailsViewModel>()
                {
                    new HouseDetailsViewModel()
                    {

                    }
                },
                Rating = 6
            };

            return model;
        }
    }
}
