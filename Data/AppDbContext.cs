using Data.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;

public class AppDbContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    
    public AppDbContext() 
        : base()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .SetBasePath(Directory.GetCurrentDirectory())
            .Build();
 
        optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
    }
}