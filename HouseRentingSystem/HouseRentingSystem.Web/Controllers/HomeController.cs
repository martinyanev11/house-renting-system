using System.Diagnostics;
using HouseRentingSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
