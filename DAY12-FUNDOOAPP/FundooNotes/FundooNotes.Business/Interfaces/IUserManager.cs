using FundooNotes.Common;
using FundooNotes.Common.DTOs;

namespace FundooNotes.Business.Interfaces
{
    /// <summary>
    /// Business rules for user management - orchestrates the repository,
    /// password hashing, token generation and the email notification call.
    /// </summary>
    public interface IUserManager
    {
        Task<ResponseModel<string>> RegisterAsync(RegistrationDTO dto);
        Task<ResponseModel<string>> LoginAsync(LoginDTO dto);
        Task<ResponseModel<string>> ForgotPasswordAsync(ForgotPasswordDTO dto);
        Task<ResponseModel<string>> ResetPasswordAsync(ResetPasswordDTO dto);
        Task<ResponseModel<string>> ChangePasswordAsync(int userId, ChangePasswordDTO dto);
    }
}