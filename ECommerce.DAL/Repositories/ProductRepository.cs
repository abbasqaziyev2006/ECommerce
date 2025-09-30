using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Repositories
{
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetByCategoryAsync(string categoryName)
        {
            return await _dbContext.Products
                .Where(p => p.Category!.Name == categoryName)
                .ToListAsync();
        }



        public async Task<Product?> GetByIdWithDetailsAsync(int id)
        {
            return await _dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
