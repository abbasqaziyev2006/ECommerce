using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;


namespace ECommerce.BLL.Services
{
    public class ProductSizeManager : CrudManager<ProductSize, CreateProductSizeViewModel, UpdateProductSizeViewModel, ProductSizeViewModel>, IProductSizeService
    {
        public ProductSizeManager(IRepository<ProductSize> repository, IMapper mapper) : base(repository, mapper) { }
    }
}