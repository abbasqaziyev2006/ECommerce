using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Petshop.BLL.ViewModels;

namespace ECommerce.BLL.Services
{
    public class HomeManager : IHomeService
    {
        private readonly IContactInfoService _contactInfoService;
        private readonly ISocialService _socialService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly ICurrencyService _currencyService;


        public HomeManager(IContactInfoService contactInfoService, ISocialService socialService, ICategoryService categoryService, IProductService productService, ILanguageService languageService, ICurrencyService currencyService)
        {
            _contactInfoService = contactInfoService;
            _socialService = socialService;
            _categoryService = categoryService;
            _productService = productService;
            _languageService = languageService;
            _currencyService = currencyService;
        }

        public async Task<HomeViewModel> GetHomeViewModel()
        {
            var contactInfoList = await _contactInfoService.GetAllAsync();

            var contactInfo = new ContactInfoViewModel();

            if (contactInfoList == null || !contactInfoList.Any())
            {
                contactInfo.Phone = "";
                contactInfo.Email = "";
                contactInfo.Address = "";
                contactInfo.Copyright = "";
            }
            else
            {
                contactInfo = contactInfoList.First();
            }

            var socials = await _socialService.GetAllAsync();

            if (socials == null || !socials.Any())
            {
                socials = new List<SocialViewModel>();
            }

            var categories = await _categoryService.GetAllAsync();

            if (categories == null || !categories.Any())
            {
                categories = new List<CategoryViewModel>();
            }

            var hotDeals = await _productService.GetHotDealsAsync(5);
            if (hotDeals == null || !hotDeals.Any())
            {
                hotDeals = new List<ProductViewModel>();
            }

            var recommendedProducts = await _productService.GetRecommendedProductsAsync(5);
            if (recommendedProducts == null || !recommendedProducts.Any())
            {
                recommendedProducts = new List<ProductViewModel>();
            }

            var languages = await _languageService.GetAllAsync();
            if (languages == null || !languages.Any())
            {
                languages = new List<LanguageViewModel>();
            }

            var currencies = await _currencyService.GetAllAsync();
            if (currencies == null || !currencies.Any())
            {
                currencies = new List<CurrencyViewModel>();
            }

            return new HomeViewModel
            {
                ContactInfo = contactInfo,
                Socials = socials,
                Categories = categories,
                HotDeals = hotDeals,
                RecommendedProducts = recommendedProducts,
                Languages = languages,
                Currencies = currencies
            };
        }
    }

}
