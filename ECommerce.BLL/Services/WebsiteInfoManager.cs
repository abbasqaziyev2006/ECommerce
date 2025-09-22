using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Petshop.BLL.Services;
using static ECommerce.BLL.ViewModels.WebsiteInfoViewModel;

namespace ECommerce.BLL.Services
{
    public class WebsiteInfoManager : CrudManager<WebsiteInfo, CreateWebsiteInfoViewModel, UpdateWebsiteInfoViewModel, WebsiteInfoViewModel>, IWebsiteInfoService
    {
        public WebsiteInfoManager(IRepository<WebsiteInfo> repository, IMapper mapper) : base(repository, mapper) { }
    }
}