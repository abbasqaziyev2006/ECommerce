using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Query;
using Petshop.BLL.Services;
using System.Linq.Expressions;
namespace ECommerce.BLL.Services
{
    public class ProductManager : CrudManager<Product, CreateProductViewModel, UpdateProductViewModel, ProductViewModel>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductManager(IRepository<Product> repository, IMapper mapper, IProductRepository productRepository) : base(repository, mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetHotDealsAsync(int count)
        {
            var productsFromDb = await _productRepository.GetHotDealsAsync(count);

            var products = _mapper.Map<List<ProductViewModel>>(productsFromDb);

            return products;
        }

        public async Task<List<ProductViewModel>> GetPopularProductsAsync(int count)
        {
            var productsFromDb = await _productRepository.GetPopularProductsAsync(count);

            var products = _mapper.Map<List<ProductViewModel>>(productsFromDb);

            return products;
        }

        public async Task<List<ProductViewModel>> GetRecommendedProductsAsync(int count)
        {
            var productsFromDb = await _productRepository.GetRecommendedProductsAsync(count);

            var products = _mapper.Map<List<ProductViewModel>>(productsFromDb);

            return products;
        }
    }
}