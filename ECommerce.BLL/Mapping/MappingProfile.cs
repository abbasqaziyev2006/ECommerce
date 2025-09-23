using AutoMapper;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECommerce.BLL.ViewModels.ContactInfoViewModel;

namespace ECommerce.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressViewModel>().ReverseMap();
            CreateMap<Address, CreateAddressViewModel>().ReverseMap();
            CreateMap<Address, UpdateAddressViewModel>().ReverseMap();

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

       
            CreateMap<ProductSize, ProductSizeViewModel>().ReverseMap();
            CreateMap<ProductSize, CreateProductSizeViewModel>().ReverseMap();
            CreateMap<ProductSize, UpdateProductSizeViewModel>().ReverseMap();

            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Product, CreateProductViewModel>().ReverseMap();
            CreateMap<Product, UpdateProductViewModel>().ReverseMap();

            CreateMap<Social, SocialViewModel>().ReverseMap();
            CreateMap<Social, CreateSocialViewModel>().ReverseMap();
            CreateMap<Social, UpdateSocialViewModel>().ReverseMap();

            CreateMap<ContactInfo, ContactInfoViewModel>().ReverseMap();
            CreateMap<ContactInfo, CreateWebsiteInfoViewModel>().ReverseMap();
            CreateMap<ContactInfo, UpdateWebsiteInfoViewModel>().ReverseMap();

            CreateMap<Wishlist, WishlistViewModel>().ReverseMap();
            CreateMap<Wishlist, CreateWishlistViewModel>().ReverseMap();
            CreateMap<Wishlist, UpdateWishlistViewModel>().ReverseMap();


        }
    }

}