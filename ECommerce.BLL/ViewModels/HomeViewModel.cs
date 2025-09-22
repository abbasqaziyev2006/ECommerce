using ECommerce.BLL.ViewModels;

namespace Petshop.BLL.ViewModels;
public class HomeViewModel
{
    public WebsiteInfoViewModel? WebsiteInfo { get; set; }
    public List<SocialViewModel>? Socials { get; set; } = [];
    public List<CategoryViewModel>? Categories { get; set; } = [];
    public List<ProductViewModel>? HotDeals { get; set; } = [];
    public List<ProductViewModel>? PopularProducts { get; set; } = [];
    public List<ProductViewModel>? RecommendedProducts { get; set; } = [];
    public List<LanguageViewModel>? Languages { get; set; } = [];
    public List<CurrencyViewModel>? Currencies { get; set; } = [];
}
