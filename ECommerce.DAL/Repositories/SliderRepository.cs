using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Repositories
{
    public class SliderRepository : EfCoreRepository<Slider>, ISliderRepository
    {
        private readonly AppDbContext _dbContext;
        public SliderRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Slider>> GetSliderByIdAsync(int id)
        {
            return await _dbContext.Sliders
                .Where(s => s.Id == id)
                .ToListAsync();
        }
    }
}

