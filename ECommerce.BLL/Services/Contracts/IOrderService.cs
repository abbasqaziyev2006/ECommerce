using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IOrderService : ICrudService<Order, CreateOrderViewModel, UpdateOrderViewModel, OrderViewModel> 
    { 
    }
}

