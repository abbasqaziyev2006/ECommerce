using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;


namespace ECommerce.BLL.Services
{
    public class WishlistManager: CrudManager<Wishlist, CreateWishlistViewModel, UpdateWishlistViewModel, WishlistViewModel>, IWishlistItemService
    {
        public WishlistManager(IRepository<Wishlist> repository, IMapper mapper) : base(repository, mapper) { }
    }
}