namespace ECommerce.DAL.DataContext.Entities
{
    public class ContactInfo : Entity
    {
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}