using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Repositories
{
    public class WishlistItemRepository : EfCoreRepository<WishlistItem>, IWishlistItemRepository
    {
        public WishlistItemRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

