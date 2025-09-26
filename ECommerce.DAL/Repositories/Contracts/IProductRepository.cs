using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.DAL.Repositories.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetByCategoryAsync(string categoryName);
        Task<Product?> GetByIdWithDetailsAsync(int id);
    }
}
