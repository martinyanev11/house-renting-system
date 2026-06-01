using HouseRentingSystem.Models.ViewModels.House;
using HouseRentingSystem.Services.Contracts;
using HouseRentingSystem.Web.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem.Web.Controllers
{
    public class HousesController : BaseController
    {
        private readonly IHouseService _houseService;

        public HousesController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var model = await _houseService.GetAllHousesAsync();
            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var currentUserId = this.User.GetId();

            var model = await _houseService.GetAgentHousesAsync(currentUserId);
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            HouseDetailsViewModel? house = 
                await _houseService.GetHouseDetailsAsync(id);

            if (house == null)
            {
                return BadRequest();
            }

            return View(house);
        }
    }
}
