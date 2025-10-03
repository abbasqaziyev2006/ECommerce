using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class ShopManager : IShopService
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ShopManager(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<ShopViewModel> GetShopAsync()
        {
            var categories = await _categoryService.GetAllAsync(predicate: x => !x.IsDeleted);
            var products = await _productService.GetAllAsync(predicate: x => !x.IsDeleted, include: x => x.Include(pv => pv.ProductVariants).ThenInclude(i => i.ProductImages).Include(pv => pv.ProductVariants));

            var shopViewModel = new ShopViewModel
            {
                Products = products.ToList(),
                Categories = categories.ToList()
            };

            return shopViewModel;
        }
    }
}