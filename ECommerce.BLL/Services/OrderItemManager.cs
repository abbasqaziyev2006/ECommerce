using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Petshop.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class OrderItemManager : CrudManager<OrderItem, CreateOrderItemViewModel, UpdateOrderItemViewModel, OrderItemViewModel>, IOrderItemService
    {
        public OrderItemManager(IRepository<OrderItem> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}