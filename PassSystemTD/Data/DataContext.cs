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
        var users = new List<User>();
        var roles = new List<Role>();

        var random = new Random();
        for (int i = 1; i <= 50; i++)
        {
            var userId = Guid.NewGuid();
            var isStudent = i % 2 == 0;
            
            string groupNumber = null;
            if (isStudent)
            {
                int group = random.Next(1, 100); 
                int year = random.Next(16, 26); 
                int subgroup = random.Next(1, 21); 
                groupNumber = $"{group:D2}{year:D2}{subgroup:D2}";
            }

            users.Add(new User
            {
                Id = userId,
                Name = $"User{i}",
                Email = $"user{i}@example.com",
                BirthDate = DateTime.SpecifyKind(new DateTime(2005, 3, 9, 0, 0, 0, 0), DateTimeKind.Utc),
                Password = PasswordHasher.Hash($"string{i}"),
                Gender = (Gender)(i % 2 == 0 ? Gender.Male : Gender.Female),
                RoleId = Guid.NewGuid(),
                GroupNumber = groupNumber
            });

            roles.Add(new Role(userId, i % 50 == 0, isStudent, i % 8 == 0, i % 10 == 0));
        }

        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Role>().HasData(roles);
        
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

