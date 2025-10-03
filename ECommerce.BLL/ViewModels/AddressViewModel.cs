namespace ECommerce.BLL.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? AppUserId { get; set; }
    }

    public class CreateAddressViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Company { get; set; }
        public string Adress { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? Country { get; set; }
        public string PostalCode { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? AppUserId { get; set; }
    }

    public class UpdateAddressViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? AppUserId { get; set; }
    }

}
