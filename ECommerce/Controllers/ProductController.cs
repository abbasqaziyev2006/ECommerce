using ECommerce.BLL.Services.Contracts;
using ECommerce.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace  ECommerce.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(string id)
        {
            int productId = int.Parse(id.Split('-').Last());

            var model = await _productService.GetAsync(predicate: x => x.Id == productId && !x.IsDeleted,
                include: x => x
                .Include(c => c.Category)
                .Include(pv => pv.ProductVariants)
                .ThenInclude(i => i.ProductImages)
                .Include(pv => pv.ProductVariants));

            return View(model);
        }
    }
}