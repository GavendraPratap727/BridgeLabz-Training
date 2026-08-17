using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FundooNotes.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FundooNotes.Business
{
    public interface ITokenService
    {
        string GenerateJwtToken(UserEntity user);
        string GenerateResetToken();
    }

    /// <summary>
    /// Wraps JWT creation for login sessions and one-time tokens for password reset links.
    /// Reads signing key / issuer / expiry from configuration (appsettings.json -> "Jwt" section).
    /// </summary>
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJwtToken(UserEntity user)
        {
            var jwtSection = _configuration.GetSection("Jwt");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection["Key"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("firstName", user.FirstName)
            };

            var token = new JwtSecurityToken(
                issuer: jwtSection["Issuer"],
                audience: jwtSection["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(double.Parse(jwtSection["ExpiryHours"] ?? "2")),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateResetToken() =>
            Convert.ToBase64String(Guid.NewGuid().ToByteArray()) + Guid.NewGuid().ToString("N");
    }
}