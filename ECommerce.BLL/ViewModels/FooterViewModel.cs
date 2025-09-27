using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class FooterViewModel
    {
        public Logo Logo { get; set; } = null!;
        public List<Category> Categories { get; set; } = new List<Category>();
        public ContactInfo? ContactInfo { get; set; }
        public List<Language> Languages { get; set; } = new List<Language>();
        public List<Currency> Currencies { get; set; }= new List<Currency>();
        public List<Social> Socials { get; set; }= new List<Social>();
    }
}