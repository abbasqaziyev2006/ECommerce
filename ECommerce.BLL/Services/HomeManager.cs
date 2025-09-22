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
        private readonly IWebsiteInfoService _websiteInfoService;
        private readonly ISocialService _socialService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly ICurrencyService _currencyService;


        public HomeManager(IWebsiteInfoService websiteInfoService, ISocialService socialService, ICategoryService categoryService, IProductService productService, ILanguageService languageService, ICurrencyService currencyService)
        {
            _websiteInfoService = websiteInfoService;
            _socialService = socialService;
            _categoryService = categoryService;
            _productService = productService;
            _languageService = languageService;
            _currencyService = currencyService;
        }

        public async Task<HomeViewModel> GetHomeViewModel()
        {

            var websiteInfoList = await _websiteInfoService.GetAllAsync();

            var websiteInfo = new WebsiteInfoViewModel();

            if (websiteInfoList == null || !websiteInfoList.Any())
            {
                websiteInfo.HelpPhone = "";
                websiteInfo.SupportPhone = "";
                websiteInfo.Email = "";
                websiteInfo.Address = "";
                websiteInfo.Copyright = "";
            }
            else
            {
                websiteInfo = websiteInfoList.First();
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



            var popularProducts = await _productService.GetPopularProductsAsync(5);
            if (popularProducts == null || !popularProducts.Any())
            {
                popularProducts = new List<ProductViewModel>();
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
                WebsiteInfo = websiteInfo,
                Socials = socials,
                Categories = categories,
                HotDeals = hotDeals,
                PopularProducts = popularProducts,
                RecommendedProducts = recommendedProducts,
                Languages = languages,
                Currencies = currencies
            };

        }
    }

}
