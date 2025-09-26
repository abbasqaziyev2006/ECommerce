using ECommerce.BLL.Mapping;
using ECommerce.BLL.Services;
using ECommerce.BLL.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
namespace ECommerce.BLL
{
    public static class BussinessLogicLayerServiceRegistration
    {
        public static IServiceCollection AddBussinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddAutoMapper(confg => confg.AddProfile<MappingProfile>());

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IHomeService, HomeManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IContactInfoService, ContactInfoManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            //services.AddScoped<ICurrencyService, CurrencyManager>();
            services.AddScoped<ICouponService, CouponManager>();
            services.AddScoped<IProductSizeService, ProductSizeManager>();
            services.AddScoped<IOrderItemService, OrderItemManager>();
            services.AddScoped<ISocialService, SocialManager>();
            services.AddScoped<IWishlistItemService, WishlistManager>();
            services.AddScoped<BasketManager>();
            services.AddScoped<FileService>();

            return services;
        }
    }
}
