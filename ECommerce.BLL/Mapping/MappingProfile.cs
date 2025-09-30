using AutoMapper;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECommerce.BLL.ViewModels.BioViewModel;

namespace ECommerce.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Address, CreateAddressViewModel>().ReverseMap();
            CreateMap<Address, UpdateAddressViewModel>().ReverseMap();

            CreateMap<Slider, SliderViewModel>().ReverseMap();
            CreateMap<Slider, CreateSliderViewModel>().ReverseMap();
            CreateMap<Slider, UpdateSliderViewModel>().ReverseMap();


            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryViewModel>().ReverseMap();
            CreateMap<Category, UpdateCategoryViewModel>().ReverseMap();

            CreateMap<Coupon, CouponViewModel>().ReverseMap();
            CreateMap<Coupon, CreateCouponViewModel>().ReverseMap();
            CreateMap<Coupon, UpdateCouponViewModel>().ReverseMap();

            CreateMap<Language, LanguageViewModel>().ReverseMap();
            CreateMap<Language, CreateLanguageViewModel>().ReverseMap();
            CreateMap<Language, UpdateLanguageViewModel>().ReverseMap();

            CreateMap<Currency, CurrencyViewModel>().ReverseMap();
            CreateMap<Currency, CreateCurrencyViewModel>().ReverseMap();
            CreateMap<Currency, UpdateCurrencyViewModel>().ReverseMap();

            CreateMap<OrderItem, OrderItemViewModel>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemViewModel>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemViewModel>().ReverseMap();

            CreateMap<Order, OrderViewModel>().ReverseMap();
            CreateMap<Order, CreateOrderViewModel>().ReverseMap();
            CreateMap<Order, UpdateOrderViewModel>().ReverseMap();


            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Product, CreateProductViewModel>().ReverseMap();
            CreateMap<Product, UpdateProductViewModel>().ReverseMap();

            CreateMap<Social, SocialViewModel>().ReverseMap();
            CreateMap<Social, CreateSocialViewModel>().ReverseMap();
            CreateMap<Social, UpdateSocialViewModel>().ReverseMap();

            CreateMap<Bio, BioViewModel>().ReverseMap();
            CreateMap<Bio, CreateBioViewModel>().ReverseMap();
            CreateMap<Bio, UpdateBioViewModel>().ReverseMap();

            CreateMap<WishlistItem, WishlistItemViewModel>().ReverseMap();
            CreateMap<WishlistItem, CreateWishlistItemViewModel>().ReverseMap();
            CreateMap<WishlistItem, UpdateWishlistItemViewModel>().ReverseMap();


        }
    }

}