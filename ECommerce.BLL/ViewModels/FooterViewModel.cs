using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class FooterViewModel
    {
        public Logo Logo { get; set; } = null!;
        public List<Category> Categories { get; set; } = [];
        public ContactInfo? ContactInfo { get; set; }
        public List<Language> Languages { get; set; } = [];
        public List<Currency> Currencies { get; set; }= [];
        public List<Social> Socials { get; set; }= [];
    }
}