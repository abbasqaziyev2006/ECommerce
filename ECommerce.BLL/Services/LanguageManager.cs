using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using ECommerce.BLL.Services;

namespace ECommerce.BLL.Services
{
    public class LanguageManager : CrudManager<Language, LanguageViewModel, CreateLanguageViewModel, UpdateLanguageViewModel>, ILanguageService
    {
        public LanguageManager(IRepository<Language> repository, IMapper mapper) : base(repository, mapper) { }
    }
}