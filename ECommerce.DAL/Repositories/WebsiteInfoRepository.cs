using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class WebsiteInfoRepository : EfCoreRepository<ContactInfo>, IWebsiteInfoRepository
    {
        public WebsiteInfoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }

}

