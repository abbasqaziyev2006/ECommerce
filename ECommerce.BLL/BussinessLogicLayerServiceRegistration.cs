using ECommerce.BLL.Mapping;
using ECommerce.BLL.Services;
using ECommerce.BLL.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Petshop.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL
{
    public static class BussinessLogicLayerServiceRegistration
    {
        public static IServiceCollection AddBussinessLogicLayerServices(this IServiceCollection services)
        {
            services.AddAutoMapper(confg => confg.AddProfile<MappingProfile>());

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IWebsiteInfoService, WebsiteInfoManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ICurrencyService, CurrencyManager>();
            services.AddScoped<ICouponService, CouponManager>();
            services.AddScoped<IProductSizeService, ProductSizeManager>();
            services.AddScoped<IOrderItemService, OrderItemManager>();
            services.AddScoped<ISocialService, SocialViewManager>();
            services.AddScoped<IWishlistItemService, WishlistManager>();
            services.AddScoped<BasketManager>();
            services.AddScoped<FileService>();

            return services;
        }
    }
}
