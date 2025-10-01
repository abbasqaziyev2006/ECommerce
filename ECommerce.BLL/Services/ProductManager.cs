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
        public ProductManager(IRepository<Product> repository, IMapper mapper)
            : base(repository, mapper)
        {

        }
    }
}