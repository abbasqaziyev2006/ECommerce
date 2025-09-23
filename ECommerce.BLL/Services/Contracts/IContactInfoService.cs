using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using static ECommerce.BLL.ViewModels.ContactInfoViewModel;

namespace ECommerce.BLL.Services.Contracts
{
    public interface IContactInfoService : ICrudService<ContactInfo, CreateContactInfoViewModel, UpdateContactInfoViewModel, ContactInfoViewModel> 
    { 
    }
}
