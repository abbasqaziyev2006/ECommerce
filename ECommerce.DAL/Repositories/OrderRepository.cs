using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class OrderRepository : EfCoreRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

