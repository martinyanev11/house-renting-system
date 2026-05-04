using HouseRentingSystem.Models.ViewModels.House;

namespace HouseRentingSystem.Services.Contracts
{
    public interface IHouseService
    {
        public AllHousesViewModel GetHouses();
    }
}
