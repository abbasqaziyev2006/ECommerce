using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

public class HeaderManager : IHeaderService
{
    private readonly ILanguageService _languageService;
    private readonly ICurrencyService _currencyService;
    private readonly ISocialService _socialService;

    public HeaderManager(ISocialService socialService, ICurrencyService currencyService, ILanguageService languageService)
    {
        _socialService = socialService;
        _currencyService = currencyService;
        _languageService = languageService;
    }

    public async Task<HeaderViewModel> GetHeaderAsync()
    {
        var socials = await _socialService.GetAllAsync();
        var currencies = await _currencyService.GetAllAsync(predicate: x => !x.IsDeleted);
        var languages = await _languageService.GetAllAsync(predicate: x => !x.IsDeleted);

        var headerViewModel = new HeaderViewModel
        {
            Socials = socials.ToList(),
            Currencies = currencies.ToList(),
            Languages = languages.ToList()
        };

        return headerViewModel;
    }
}
