using Microsoft.AspNetCore.Mvc;

namespace PBL3.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
