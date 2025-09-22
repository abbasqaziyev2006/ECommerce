using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.Repositories.Contracts;
using Petshop.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class SocialViewManager : CrudManager<Social, CreateSocialViewModel, UpdateSocialViewModel, SocialViewModel>, ISocialService
    {
        public SocialViewManager(IRepository<Social> repository, IMapper mapper) : base(repository, mapper) { }
    }
}