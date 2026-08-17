using System.ComponentModel.DataAnnotations;

namespace FundooNotes.Common.DTOs
{
    public class RegistrationDTO
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // At least 8 chars, 1 upper, 1 lower, 1 digit, 1 special char
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$",
            ErrorMessage = "Password must be at least 8 characters and include upper, lower, digit and special character.")]
        public string Password { get; set; } = string.Empty;

        public string? Phone { get; set; }
    }
}