using System.Diagnostics;
using HouseRentingSystem.Models.ViewModels;
using HouseRentingSystem.Models.ViewModels.House;
using HouseRentingSystem.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHouseService _houseService;

        public HomeController(
            IHouseService houseService)
        {
            _houseService = houseService;
        }

        public IActionResult All()
        {
            return View(new AllHousesViewModel()
            {
                Houses = Common.GetHouses(),
                Rating = 6
            });
        }

        public IActionResult Details()
        {
            var house = Common.GetHouses().FirstOrDefault();
            return View(house);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
