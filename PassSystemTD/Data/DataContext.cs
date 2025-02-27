using Microsoft.EntityFrameworkCore;
using PassSystemTD.Entities;

namespace PassSystemTD.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<TokenEntity> BannedTokens { get; set; } = null!;
    public DbSet<Role> Role { get; set; } = null!;
}

