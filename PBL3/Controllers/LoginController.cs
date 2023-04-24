using Microsoft.AspNetCore.Mvc;
using PBL3.Models.Entities;
using PBL3.Models.Guest_Service;

namespace PBL3.Controllers
{
	public class LoginController : Controller
	{
		private readonly IGuestLogin _service;
		public LoginController(IGuestLogin service)
		{
			_service = service;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index( AccountLogin a)
		{
			_service.Login(a);
			return View();
		}
	}
}
