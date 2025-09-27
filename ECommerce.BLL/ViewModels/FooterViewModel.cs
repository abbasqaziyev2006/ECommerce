using ECommerce.DAL.DataContext.Entities;

namespace ECommerce.BLL.ViewModels
{
    public class FooterViewModel
    {
        public Logo Logo { get; set; } = null!;
        public List<Social> Socials { get; set; } = [];
    }
}