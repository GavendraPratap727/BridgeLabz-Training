using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundooNotes.Entities
{
    [Table("Users")]
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        // Salted hash. Private setters: outside code can only change these
        // through SetPassword(), never assign a raw value directly.
        [Required]
        [MaxLength(200)]
        public string PasswordHash { get; private set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string PasswordSalt { get; private set; } = string.Empty;

        [MaxLength(15)]
        public string? Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? ResetToken { get; set; }

        public DateTime? ResetTokenExpiry { get; set; }

        // EF Core needs a parameterless constructor to materialize rows -
        // kept private so application code can't accidentally create a "blank" user.
        private UserEntity()
        {
        }

        // The only way to create a user is with a plaintext password, which is
        // immediately hashed+salted here and never stored or exposed as plain text.
        public UserEntity(string firstName, string? lastName, string email, string plainPassword, string? phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            SetPassword(plainPassword);
        }

        // Re-hashes with a fresh random salt every time - used on registration,
        // password reset, and change-password.
        public void SetPassword(string plainPassword)
        {
            var (hash, salt) = PasswordHasher.HashWithSalt(plainPassword);
            PasswordHash = hash;
            PasswordSalt = salt;
        }

        public bool VerifyPassword(string plainPassword) =>
            PasswordHasher.Verify(plainPassword, PasswordHash, PasswordSalt);
    }
}