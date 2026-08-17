using System.Security.Cryptography;

namespace FundooNotes.Entities
{
    /// <summary>
    /// Salted PBKDF2 password hashing. Hash and salt are returned/stored separately
    /// (not concatenated), matching UserEntity.PasswordHash / UserEntity.PasswordSalt.
    /// </summary>
    public static class PasswordHasher
    {
        private const int SaltSize = 16;      // 128-bit salt
        private const int HashSize = 32;      // 256-bit derived key
        private const int Iterations = 100_000;

        /// <summary>
        /// Generates a brand-new random salt and hashes the password against it.
        /// Call this once per SetPassword() - never reuse a salt across users or resets.
        /// </summary>
        public static (string Hash, string Salt) HashWithSalt(string password)
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hashBytes = Rfc2898DeriveBytes.Pbkdf2(
                password, saltBytes, Iterations, HashAlgorithmName.SHA256, HashSize);

            return (Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }

        /// <summary>
        /// Re-derives a hash using the stored salt and compares it to the stored hash
        /// in constant time (avoids timing attacks).
        /// </summary>
        public static bool Verify(string password, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            byte[] expectedHash = Convert.FromBase64String(storedHash);

            byte[] computedHash = Rfc2898DeriveBytes.Pbkdf2(
                password, saltBytes, Iterations, HashAlgorithmName.SHA256, expectedHash.Length);

            return CryptographicOperations.FixedTimeEquals(expectedHash, computedHash);
        }
    }
}