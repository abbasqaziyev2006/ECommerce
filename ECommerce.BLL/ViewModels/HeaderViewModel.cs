using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class HeaderViewModel
    {
        public Logo Logo { get; set; } = null!;
        public ContactInfoViewModel WebsiteInfo { get; set; } = null!;
        public SearchInfo? SearchInfo { get; set; }
        public List<CategoryViewModel> Categories { get; set; } = new();
    }
}