using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IWishlistItemService : ICrudService<WishlistItem, WishlistItemViewModel, CreateWishlistItemViewModel, UpdateWishlistItemViewModel> 
    {
    }
}

