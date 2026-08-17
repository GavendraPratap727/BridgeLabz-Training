using FundooNotes.Context;
using FundooNotes.Entities;
using FundooNotes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity?> GetByEmailAsync(string email) =>
            await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());

        public async Task<UserEntity?> GetByIdAsync(int userId) =>
            await _context.Users.FindAsync(userId);

        public async Task<UserEntity?> GetByResetTokenAsync(string token) =>
            await _context.Users.FirstOrDefaultAsync(u => u.ResetToken == token);

        public async Task<UserEntity> AddAsync(UserEntity user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<UserEntity> UpdateAsync(UserEntity user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> EmailExistsAsync(string email) =>
            await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
    }
}