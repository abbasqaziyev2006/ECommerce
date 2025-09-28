namespace ECommerce.BLL.ViewModels
{
    public class ShopViewModel
    {
        public List<ProductViewModel> Products { get; set; } = [];
        public List<CategoryViewModel> Categories { get; set; } = [];
        public IList<string> TagNames { get; set; } = [];
    }
}