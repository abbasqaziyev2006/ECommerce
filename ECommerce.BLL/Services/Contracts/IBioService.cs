using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using static ECommerce.BLL.ViewModels.BioViewModel;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IBioService : ICrudService<Bio, BioViewModel, CreateBioViewModel, UpdateBioViewModel>
    { 
    }
}
