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

            services.AddScoped<IHeaderService, HeaderManager>();
            services.AddScoped<IFooterService, FooterManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IHomeService, HomeManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IBioService, BioManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ICurrencyService, CurrencyManager>();
            services.AddScoped<ICouponService, CouponManager>();
            services.AddScoped<IOrderItemService, OrderItemManager>();
            services.AddScoped<ISocialService, SocialManager>();
            services.AddScoped<IWishlistItemService, WishlistItemManager>();
            services.AddScoped<IShopService, ShopManager>();
            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<BasketManager>();
            services.AddScoped<FileService>();

            return services;
        }
    }
}
