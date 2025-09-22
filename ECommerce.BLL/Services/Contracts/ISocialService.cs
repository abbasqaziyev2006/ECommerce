using ECommerce.BLL.ViewModels;

namespace ECommerce.BLL.Services.Contracts
{
    public interface ISocialService : ICrudService<Social, CreateSocialViewModel, UpdateSocialViewModel, SocialViewModel> 
    {
    }
}
