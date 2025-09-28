using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


    public class ShopController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ShopController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productService.GetAllAsync(include:
                x => x.Include(h => h.ProductSizes));
            products = products.Take(1).ToList();

            var model = new ShopViewModel
            {
                Products = products,
                Categories = categories,
            };

            return View(model);
        }

        public async Task<IActionResult> LoadMore(int skip)
        {
            var products = await _productService.GetAllAsync(include:
                x => x.Include(h => h.ProductSizes));
            products = products.Skip(skip).Take(1).ToList();

            var json = JsonConvert.SerializeObject(products);

            return Json(json);
        }
    }

