using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using static ECommerce.BLL.ViewModels.ContactInfoViewModel;

namespace ECommerce.BLL.Services
{
    public class ContactInfoManager : CrudManager<ContactInfo, CreateContactInfoViewModel, UpdateContactInfoViewModel, ContactInfoViewModel>, IContactInfoService
    {
        public ContactInfoManager(IRepository<ContactInfo> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
