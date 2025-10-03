using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class RegisterViewModel
    {
        public string? FullName { get; set; }
        public required string UserName { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public IFormFile? ProfileImage { get; set; }

        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password")]
        public required string ConfirmPassword { get; set; }
    }
}