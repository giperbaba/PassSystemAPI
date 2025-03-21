using Microsoft.EntityFrameworkCore;
using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;
using PassSystemTD.Utils;
using Document = System.Reflection.Metadata.Document;

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
            .HasForeignKey<Role>(r => r.UserId) 
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Role>()
            .HasIndex(r => r.UserId)
            .IsUnique();
    }
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<TokenEntity> BannedTokens { get; set; } = null!;
    public DbSet<Role> Role { get; set; } = null!;
    public DbSet<Pass> Passes { get; set; } = null!;
    public DbSet<Proof> Proofs { get; set; } = null!;
}

