using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class LoginViewModel
    {
        //public required string Email { get; set; }
        //[DataType(DataType.Password)]
        public required string Password { get; set; }
        public required string UserName { get; set; }
        [DataType(DataType.Password)]
        public string? ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}

