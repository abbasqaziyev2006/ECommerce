using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Repositories.Contracts
{
    public interface IWishlistItemRepository : IRepository<WishlistItem>
    {
    }
}
