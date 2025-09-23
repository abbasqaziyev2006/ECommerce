using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Repositories
{
   
    public class ProductRepository : EfCoreRepository<Product>, IProductRepository
    {
        private readonly IOrderItemRepository _orderItemService;
        public ProductRepository(AppDbContext dbContext, IOrderItemRepository orderItemService) : base(dbContext)
        {
            _orderItemService = orderItemService;
        }

        public async Task<List<Product>> GetHotDealsAsync(int count)
        {
            var list = DbContext.Products
                .Where(p => p.DiscountPrice > 0)
                .OrderBy(p => p.CreatedAt) 
                .Take(count)
                .Include(z => z.ProductSizes);

            if (list == null || !list.Any())
            {
                return new List<Product>();
            }

            var listResult = await list.ToListAsync();

            return listResult;
        }

  

        public async Task<List<Product>> GetRecommendedProductsAsync(int count)
        {
            var recommendedProductIds = await DbContext.OrderItems
                .GroupBy(oi => oi.ProductId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .Take(count)
                .ToListAsync();

            var products = await DbContext.Products
             .Where(p => recommendedProductIds.Contains(p.Id))
             .Include(z => z.ProductSizes)
             .ToListAsync();

            return products;
        }
    }
}
