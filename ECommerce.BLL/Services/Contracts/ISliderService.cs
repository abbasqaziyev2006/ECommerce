using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
namespace ECommerce.BLL.Services.Contracts
{
    public interface ISliderService : ICrudService<Slider, SliderViewModel, CreateSliderViewModel, UpdateSliderViewModel>
    {
        Task<List<SliderViewModel>> GetSlidersByIdAsync(int id);
    }
}

