using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class LanguageRepository : EfCoreRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

