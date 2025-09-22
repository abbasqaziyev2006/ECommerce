namespace ECommerce.DAL.DataContext.Entities
{
    public class Currency : TimeStample
    {
        public string Name { get; set; } = null!;
        public string Symbol { get; set; } = null!;
        public double ExchangeRate { get; set; }
    }
}