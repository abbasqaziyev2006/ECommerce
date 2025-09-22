using ECommerce.DAL.DataContext;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class SocialRepository : EfCoreRepository<Social>, ISocialRepository
    {
        public SocialRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

