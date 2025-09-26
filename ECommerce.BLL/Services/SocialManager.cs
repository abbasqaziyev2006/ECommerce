using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.Repositories.Contracts;
using ECommerce.BLL.Services;


namespace ECommerce.BLL.Services
{
    public class SocialManager : CrudManager<Social, CreateSocialViewModel, UpdateSocialViewModel, SocialViewModel>, ISocialService
    {
        public SocialManager(IRepository<Social> repository, IMapper mapper) : base(repository, mapper) { }
    }
}