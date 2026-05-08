using HouseRentingSystem.Models.ViewModels.House;

namespace HouseRentingSystem.Services.Contracts
{
    public interface IHouseService
    {
        public Task<IndexViewModel> GetIndexDataAsync();
        public Task<AllHousesViewModel> GetAllHousesAsync();
        public Task<AllHousesViewModel> GetAgentHousesAsync(Guid id);
        Task<HouseDetailsViewModel?> GetHouseDetailsAsync(Guid id);
    }
}
