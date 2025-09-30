using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

public class FooterManager : IFooterService
{
    private readonly ILanguageService _languageService;
    private readonly ICurrencyService _currencyService;
    private readonly ISocialService _socialService;
    private readonly IBioService _bioService;

    public FooterManager(ISocialService socialService, ICurrencyService currencyService, ILanguageService languageService, IBioService bioService)
    {
        _socialService = socialService;
        _currencyService = currencyService;
        _languageService = languageService;
        _bioService = bioService;
    }

    public async Task<FooterViewModel> GetFooterAsync()
    {
        var socials = await _socialService.GetAllAsync();
        var currencies = await _currencyService.GetAllAsync(predicate: x => !x.IsDeleted);
        var languages = await _languageService.GetAllAsync(predicate: x => !x.IsDeleted);
        var bio = await _bioService.GetAllAsync(predicate: x => !x.IsDeleted);

        var footerViewModel = new FooterViewModel
        {
            Socials = socials.ToList(),
            Currencies = currencies.ToList(),
            Languages = languages.ToList(),
            Bio = bio.ToList().FirstOrDefault(),
        };

        return footerViewModel;
    }
}
