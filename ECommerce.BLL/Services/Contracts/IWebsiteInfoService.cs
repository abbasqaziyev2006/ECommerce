using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using static ECommerce.BLL.ViewModels.WebsiteInfoViewModel;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IWebsiteInfoService : ICrudService<WebsiteInfo, CreateWebsiteInfoViewModel, UpdateWebsiteInfoViewModel, WebsiteInfoViewModel> { 
    }
}
