using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.DAL.Repositories
{
    public class ContactInfoRepository : EfCoreRepository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }

}

