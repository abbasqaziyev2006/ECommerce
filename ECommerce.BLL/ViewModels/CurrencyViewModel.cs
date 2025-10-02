namespace ECommerce.BLL.ViewModels
{
    public class CurrencyViewModel
    {
        public int Id { get; set; }

        public string CurrencyName { get; set; } = null!;

        public string Symbol { get; set; } = null!;

        public string CountryName { get; set; } = null!;

        public string IconName { get; set; } = null!;
    }


    public class CreateCurrencyViewModel
    {
    }

    public class UpdateCurrencyViewModel
    {
    }

  
}