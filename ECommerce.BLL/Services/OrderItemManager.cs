using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using ECommerce.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class OrderItemManager : CrudManager<OrderItem, OrderItemViewModel, CreateOrderItemViewModel, UpdateOrderItemViewModel>, IOrderItemService
    {
        public OrderItemManager(IRepository<OrderItem> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}