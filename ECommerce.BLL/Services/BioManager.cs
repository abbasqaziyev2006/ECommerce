using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using static ECommerce.BLL.ViewModels.BioViewModel;

namespace ECommerce.BLL.Services
{
    public class BioManager : CrudManager<Bio, BioViewModel, CreateBioViewModel, UpdateBioViewModel>, IBioService
    {
        public BioManager(IRepository<Bio> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
