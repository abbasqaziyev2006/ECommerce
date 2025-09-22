using Petshop.BLL.ViewModels;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IHomeService
    {
        Task<HomeViewModel> GetHomeViewModel();
    }
}
