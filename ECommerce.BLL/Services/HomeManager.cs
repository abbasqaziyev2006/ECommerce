using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
namespace ECommerce.BLL.Services
{
    public class HomeManager : IHomeService
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public HomeManager(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<HomeViewModel> GetHomeViewModel()
        {
            var categories = await _categoryService.GetAllAsync(predicate: x => !x.IsDeleted);

            var products = await _productService.GetAllAsync(predicate: x => !x.IsDeleted);

            var homeViewModel = new HomeViewModel
            {
                Categories = categories.ToList(),
                Products = products.ToList()

            };

            return homeViewModel;
        }
    }

}
