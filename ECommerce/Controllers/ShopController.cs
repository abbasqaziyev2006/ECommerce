using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ECommerce.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;
        private readonly IProductService _productService;

        public ShopController(IShopService shopService, IProductService productService)
        {
            _shopService = shopService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _shopService.GetShopAsync();
            ViewBag.ProductCount = model.Products.Count;
            model.Products = model.Products.Take(4).ToList();
            return View(model);
        }

        public async Task<IActionResult> ShopByCategory(int id)
        {
            var products = await _productService.GetAllAsync(
                include: q => q.Include(p => p.Category!)
            );

            var categoryProducts = products
                .Where(p => p.CategoryId == id)
                .ToList();

            var model = new ShopViewModel
            {
                Products = categoryProducts.Take(3).ToList()
            };

            ViewBag.ProductCount = categoryProducts.Count;

            return View("Index", model);
        }

    }
}

