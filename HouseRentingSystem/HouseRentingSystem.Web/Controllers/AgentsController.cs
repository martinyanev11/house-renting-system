using HouseRentingSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Web.Controllers
{
    public class AgentsController : BaseController
    {


        public AgentsController()
        {
            
        }

        public async Task<IActionResult> Become()
        {
            return View();
        }
    }
}
