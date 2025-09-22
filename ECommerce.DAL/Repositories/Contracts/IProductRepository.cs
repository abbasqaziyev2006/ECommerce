using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.DAL.Repositories.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetHotDealsAsync(int count);
        Task<List<Product>> GetPopularProductsAsync(int count);
        Task<List<Product>> GetRecommendedProductsAsync(int count);
    }
}
