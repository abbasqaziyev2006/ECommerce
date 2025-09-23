using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace ECommerce.BLL.Services.Contracts
{
    public interface IProductService : ICrudService<Product, ProductViewModel, CreateProductViewModel, UpdateProductViewModel>
    {
        Task<List<ProductViewModel>> GetHotDealsAsync(int count);
        Task<List<ProductViewModel>> GetRecommendedProductsAsync(int count);
    }
}

