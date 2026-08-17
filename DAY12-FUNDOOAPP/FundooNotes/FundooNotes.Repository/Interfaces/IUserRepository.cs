using FundooNotes.Entities;

namespace FundooNotes.Repository.Interfaces
{
    /// <summary>
    /// Pure data-access contract. No business rules here - only CRUD against the DbContext.
    /// </summary>
    public interface IUserRepository
    {
        Task<UserEntity?> GetByEmailAsync(string email);
        Task<UserEntity?> GetByIdAsync(int userId);
        Task<UserEntity?> GetByResetTokenAsync(string token);
        Task<UserEntity> AddAsync(UserEntity user);
        Task<UserEntity> UpdateAsync(UserEntity user);
        Task<bool> EmailExistsAsync(string email);
    }
}