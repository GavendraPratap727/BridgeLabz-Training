using System.ComponentModel.DataAnnotations;

namespace FundooNotes.Common.DTOs
{
    public class ForgotPasswordDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }

    public class ResetPasswordDTO
    {
        [Required]
        public string Token { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$",
            ErrorMessage = "Password must be at least 8 characters and include upper, lower, digit and special character.")]
        public string NewPassword { get; set; } = string.Empty;
    }

    // Used by an already-logged-in user (has UserId from the JWT) to change password
    public class ChangePasswordDTO
    {
        [Required]
        public string OldPassword { get; set; } = string.Empty;

        [Required]
        public string NewPassword { get; set; } = string.Empty;
    }
}