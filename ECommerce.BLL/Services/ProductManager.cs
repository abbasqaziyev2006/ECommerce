using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
namespace ECommerce.BLL.Services
{
    public class ProductManager : CrudManager<Product, ProductViewModel, CreateProductViewModel, UpdateProductViewModel>,
     IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public ProductManager(IRepository<Product> repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetPagedProducts(int page, int pageSize)
        {
            var products = await _repository.GetAllAsync();
            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return _mapper.Map<IEnumerable<ProductViewModel>>(pagedProducts);
        }
    }
}
