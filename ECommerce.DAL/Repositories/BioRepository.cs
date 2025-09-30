using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using static ECommerce.DAL.Repositories.BioRepository;

namespace ECommerce.DAL.Repositories
{
    public partial class BioRepository : EfCoreRepository<Bio>, IBioRepository
    {
        public BioRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }

}

