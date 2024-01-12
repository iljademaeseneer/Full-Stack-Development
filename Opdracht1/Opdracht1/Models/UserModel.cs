// UserModel.cs
namespace Opdracht1.Models
{

    using System.ComponentModel.DataAnnotations;

    public class UserModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Invalid Belgian Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [AdultValidator(ErrorMessage = "You must be an adult (18 years or older)")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Mobile Phone is required")]
        [RegularExpression(@"^(\+|00)32\d{1,9}/\d{6}$", ErrorMessage = "Invalid mobile phone number")]
        public string MobilePhone { get; set; }
    }
}