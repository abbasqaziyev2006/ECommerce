using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;

namespace ECommerce.BLL.Services
{
    public class AddressManager : CrudManager<Address, AddressViewModel, CreateAddressViewModel, UpdateAddressViewModel>, IAddressService
    {
        public AddressManager(IRepository<Address> repository, IMapper mapper) : base(repository, mapper) 
        {
        }
    }

}