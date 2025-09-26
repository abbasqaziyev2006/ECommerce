using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;


namespace ECommerce.BLL.Services
{
    public class CouponManager : CrudManager<Coupon, CreateCouponViewModel, UpdateCouponViewModel, CouponViewModel>, ICouponService
    {
        public CouponManager(IRepository<Coupon> repository, IMapper mapper) : base(repository, mapper) { }
    }
}