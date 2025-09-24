using ECommerce.DAL.DataContext;
using ECommerce.DAL.Repositories;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL
{
    public static class DataAccessLayerServiceRegistration
    {
        public static IServiceCollection AddDataAccessLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), options =>
            {
                options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
            }));


            services.AddScoped<DataInitializer>();

            services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductSizeRepository, ProductSizeRepository>();
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IWishlistRepository, WishlistRepository>();

            return services;
        }
    }
}
