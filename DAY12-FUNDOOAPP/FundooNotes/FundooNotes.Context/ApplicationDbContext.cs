using FundooNotes.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooNotes.Context
{
    /// <summary>
    /// EF Core DbContext - configures the DB connection lifecycle and entity mappings.
    /// Registered as Scoped (default for AddDbContext) so one instance is used per HTTP request.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique();
            });
        }
    }
}