namespace ECommerce.BLL.ViewModels
{
    public class ContactInfoViewModel
    {
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Copyright { get; set; }


        public class CreateContactInfoViewModel
        {
        }

        public class UpdateContactInfoViewModel
        {
        }
    }
}