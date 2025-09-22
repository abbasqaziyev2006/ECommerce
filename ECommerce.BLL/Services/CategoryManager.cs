using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Petshop.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class CategoryManager : CrudManager<Category, CategoryViewModel, CreateCategoryViewModel, UpdateCategoryViewModel>, ICategoryService
    {
        public CategoryManager(IRepository<Category> respository, IMapper mapper) : base(respository, mapper)
        {
        }
    }
}