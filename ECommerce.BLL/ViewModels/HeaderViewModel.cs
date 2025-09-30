using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class HeaderViewModel
    {
        public List<SocialViewModel> Socials { get; set; } = [];
        public List<CurrencyViewModel> Currencies { get; set; } = [];
        public List<LanguageViewModel> Languages { get; set; } = [];
        public List<BasketItemViewModel> BasketItems { get; set; }=null!;
    }
}