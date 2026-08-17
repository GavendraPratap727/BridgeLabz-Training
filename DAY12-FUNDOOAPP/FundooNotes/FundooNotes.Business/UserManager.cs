using FundooNotes.Business.Interfaces;
using FundooNotes.Common;
using FundooNotes.Common.DTOs;
using FundooNotes.Entities;
using FundooNotes.Repository.Interfaces;

namespace FundooNotes.Business
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IEmailService _emailService;

        public UserManager(IUserRepository userRepository, ITokenService tokenService, IEmailService emailService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _emailService = emailService;
        }

        public async Task<ResponseModel<string>> RegisterAsync(RegistrationDTO dto)
        {
            if (await _userRepository.EmailExistsAsync(dto.Email))
                return ResponseModel<string>.Fail("An account with this email already exists.");

            // Password is hashed+salted inside the constructor - UserManager never
            // touches PasswordHash/PasswordSalt directly, it can't, they're private-set.
            var user = new UserEntity(dto.FirstName, dto.LastName, dto.Email, dto.Password, dto.Phone);

            await _userRepository.AddAsync(user);
            return ResponseModel<string>.Ok("Registration successful.");
        }

        public async Task<ResponseModel<string>> LoginAsync(LoginDTO dto)
        {
            var user = await _userRepository.GetByEmailAsync(dto.Email);
            if (user is null || !user.VerifyPassword(dto.Password))
                return ResponseModel<string>.Fail("Invalid email or password.");

            var token = _tokenService.GenerateJwtToken(user);
            return ResponseModel<string>.Ok("Login successful.", token);
        }

        public async Task<ResponseModel<string>> ForgotPasswordAsync(ForgotPasswordDTO dto)
        {
            var user = await _userRepository.GetByEmailAsync(dto.Email);

            // Respond the same way whether or not the account exists, so the endpoint
            // can't be used to enumerate registered emails.
            if (user is null)
                return ResponseModel<string>.Ok("If that email is registered, a reset link has been sent.");

            user.ResetToken = _tokenService.GenerateResetToken();
            user.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(30);
            await _userRepository.UpdateAsync(user);

            await _emailService.SendPasswordResetEmailAsync(user.Email, user.ResetToken);

            return ResponseModel<string>.Ok("If that email is registered, a reset link has been sent.");
        }

        public async Task<ResponseModel<string>> ResetPasswordAsync(ResetPasswordDTO dto)
        {
            var user = await _userRepository.GetByResetTokenAsync(dto.Token);
            if (user is null || user.ResetTokenExpiry is null || user.ResetTokenExpiry < DateTime.UtcNow)
                return ResponseModel<string>.Fail("Reset link is invalid or has expired.");

            user.SetPassword(dto.NewPassword);
            user.ResetToken = null;
            user.ResetTokenExpiry = null;
            await _userRepository.UpdateAsync(user);

            return ResponseModel<string>.Ok("Password has been reset successfully.");
        }

        public async Task<ResponseModel<string>> ChangePasswordAsync(int userId, ChangePasswordDTO dto)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user is null)
                return ResponseModel<string>.Fail("User not found.");

            if (!user.VerifyPassword(dto.OldPassword))
                return ResponseModel<string>.Fail("Old password is incorrect.");

            user.SetPassword(dto.NewPassword);
            await _userRepository.UpdateAsync(user);

            return ResponseModel<string>.Ok("Password changed successfully.");
        }
    }
}