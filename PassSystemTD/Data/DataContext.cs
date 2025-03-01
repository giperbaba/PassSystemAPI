using Microsoft.EntityFrameworkCore;
using PassSystemTD.Entities;

namespace PassSystemTD.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        //Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)
            .WithOne(r => r.User)
            .HasForeignKey<Role>(r => r.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<TokenEntity> BannedTokens { get; set; } = null!;
    public DbSet<Role> Role { get; set; } = null!;
}

