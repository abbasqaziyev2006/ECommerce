using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;


namespace ECommerce.BLL.Services
{
    public class WishlistManager : CrudManager<WishlistItem, WishlistItemViewModel, CreateWishlistItemViewModel, UpdateWishlistItemViewModel>, IWishlistItemService
    {
        public WishlistManager(IRepository<WishlistItem> repository, IMapper mapper) : base(repository, mapper) { }
    }
}