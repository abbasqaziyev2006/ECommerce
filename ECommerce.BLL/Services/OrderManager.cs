using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using ECommerce.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class OrderManager : CrudManager<Order, CreateOrderViewModel, UpdateOrderViewModel, OrderViewModel>, IOrderService
    {
        public OrderManager(IRepository<Order> repository, IMapper mapper) : base(repository, mapper) { }
    }
}