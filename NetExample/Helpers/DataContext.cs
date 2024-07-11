// DataContext.cs
using Microsoft.EntityFrameworkCore;
using NetExample.Entities;

namespace NetExample.Helpers;
using BCrypt.Net;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("NetExampleDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            FirstName = "Gabon",
            LastName = "Leon",
            Username = "string",
            Password = BCrypt.HashPassword("string")
        });
    }

    public DbSet<User> Users { get; set; }
}
