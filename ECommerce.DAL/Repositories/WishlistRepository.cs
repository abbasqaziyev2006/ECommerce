using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class WishlistRepository : EfCoreRepository<Wishlist>, IWishlistRepository
    {
        public WishlistRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
   

}

