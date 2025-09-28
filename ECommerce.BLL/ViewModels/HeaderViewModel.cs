using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class HeaderViewModel
    {
        public ContactInfoViewModel ContactInfo { get; set; } = null!;
        public List<CategoryViewModel> Categories { get; set; } = new();
        public List<Language> Languages { get; set; }= new(); 
        public List<Currency> Currencies { get; set; }= new();
        public List<BasketItemViewModel> BasketItems { get; set; }=null!;
    }
}