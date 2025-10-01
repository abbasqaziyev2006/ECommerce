using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
namespace ECommerce.BLL.Services.Contracts
{
    public interface IProductService : ICrudService<Product, ProductViewModel,CreateProductViewModel, UpdateProductViewModel>
    {

    }
}

