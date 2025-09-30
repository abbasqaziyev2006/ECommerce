using ECommerce.BLL.Services.Contracts;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce.MVC.Controllers
{ 
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _homeService.GetHomeViewModel();
            return View(model);
        }
    }
}
