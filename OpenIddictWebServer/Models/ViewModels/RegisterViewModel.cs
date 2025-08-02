using System.ComponentModel.DataAnnotations;

namespace OpenIddictWebServer.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters in length", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwor confirmation is required.")]
        [Compare("Password", ErrorMessage = "The passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation password")]
        public string ConfirmPassword { get; set; }

    }
}
