using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IOrderItemService : ICrudService<OrderItem, OrderItemViewModel, CreateOrderItemViewModel, UpdateOrderItemViewModel>
    {
    }
}
