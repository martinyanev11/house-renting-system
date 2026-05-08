using HouseRentingSystem.Data;
using HouseRentingSystem.Models.ViewModels.House;
using HouseRentingSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Services
{
    public class HouseService : IHouseService
    {
        private readonly ApplicationDbContext _data;
        public HouseService(ApplicationDbContext data)
        {
            _data = data;
        }

        public async Task<AllHousesViewModel> GetAgentHousesAsync(Guid id)
        {
            var allHouses = new AllHousesViewModel()
            {
                Houses = await _data.Houses
                    .Where(h => h.Agent.UserId == id)
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl
                    })
                    .ToListAsync()
            };

            return allHouses;
        }

        public async Task<AllHousesViewModel> GetAllHousesAsync()
        {
            var allHouses = new AllHousesViewModel()
            {
                Houses = await _data.Houses
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Id = h.Id,
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl
                    })
                    .ToListAsync()
            };

            return allHouses;
        }

        public async Task<HouseDetailsViewModel?> GetHouseDetailsAsync(Guid id)
        {
            return await _data.Houses
                .Where(h => h.Id == id)
                .Select(h => new HouseDetailsViewModel()
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IndexViewModel> GetIndexDataAsync()
        {
            var allHouses = new IndexViewModel()
            {
                TotalHouses = await _data.Houses.CountAsync(),
                TotalRents = await _data.Houses
                    .Where(h => h.RenterId != null)
                    .CountAsync(),
                Houses = await _data.Houses
                    .Select(h => new HouseIndexViewModel()
                    {
                        Title = h.Title,
                        ImageUrl = h.ImageUrl,
                    })
                    .ToListAsync()
            };

            return allHouses;
        }
    }
}
