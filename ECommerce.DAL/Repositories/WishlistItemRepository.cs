using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class WishlistItemRepository : EfCoreRepository<WishlistItem>, IWishlistRepository
    {
        public WishlistItemRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
   

}

