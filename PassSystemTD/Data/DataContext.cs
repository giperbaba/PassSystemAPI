using Microsoft.EntityFrameworkCore;
using PassSystemTD.Entities;
using PassSystemTD.Models.Enums;
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
        var users = new List<User>();
        var roles = new List<Role>();

        var random = new Random();
        for (int i = 1; i <= 100; i++)
        {
            var userId = Guid.NewGuid();
            users.Add(new User
            {
                Id = userId,
                Name = $"User{i}",
                Email = $"user{i}@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword($"string{i}"),
                Gender = (Gender)(i % 2 == 0 ? Gender.Male : Gender.Female)
            });

            roles.Add(new Role
            {
                Id = userId,
                IsAdmin = i % 100 == 0,
                IsStudent = i % 3 == 0,
                IsTeacher = i % 5 == 0,
                IsDean = i % 7 == 0
            });
        }

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Role>().HasData(roles);
        modelBuilder.Entity<User>()
            
            .HasOne(u => u.Role)
            .WithOne(r => r.User)
            .HasForeignKey<Role>(r => r.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
    
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<TokenEntity> BannedTokens { get; set; } = null!;
    public DbSet<Role> Role { get; set; } = null!;
    public DbSet<Pass> Passes { get; set; } = null!;
    public DbSet<Proof> Proofs { get; set; } = null!;
}

