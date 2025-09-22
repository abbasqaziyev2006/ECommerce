using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class CurrencyRepository : EfCoreRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
