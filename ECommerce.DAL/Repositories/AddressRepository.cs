using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class AddressRepository : EfCoreRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
