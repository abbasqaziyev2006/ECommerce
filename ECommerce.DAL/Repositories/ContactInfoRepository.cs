using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using static ECommerce.DAL.Repositories.ContactInfoRepository;

namespace ECommerce.DAL.Repositories
{
    public partial class ContactInfoRepository : EfCoreRepository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }

}

