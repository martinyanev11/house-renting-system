using HouseRentingSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Web.Controllers
{
    public class AgentsController : BaseController
    {
        private readonly ApplicationDbContext _data;

        public AgentsController(ApplicationDbContext data)
        {
            this._data = data;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
