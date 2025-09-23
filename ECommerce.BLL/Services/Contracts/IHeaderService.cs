using ECommerce.BLL.ViewModels;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IHeaderService
    {
        Task<HeaderViewModel> GetHeaderAsync();
    }
}
