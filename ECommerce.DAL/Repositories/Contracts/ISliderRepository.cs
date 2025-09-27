using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.DAL.Repositories.Contracts
{
    public interface ISliderRepository : IRepository<Slider>
    {
        Task<List<Slider>> GetSliderByIdAsync(int id);
    }
}
