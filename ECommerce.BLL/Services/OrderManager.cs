using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using ECommerce.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class OrderManager : CrudManager<Order, OrderViewModel, CreateOrderViewModel, UpdateOrderViewModel>, IOrderService
    {
        public OrderManager(IRepository<Order> repository, IMapper mapper) : base(repository, mapper) { }
    }
}