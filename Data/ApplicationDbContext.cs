using Microsoft.EntityFrameworkCore;
using RoyalStudy.Models;

namespace RoyalStudy.Data;

/// <summary>
/// Represents the session with the database and allows querying and saving data.
/// Each DbSet property represents a table in the database.
/// </summary>

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    // Represents the "Products" table
    public DbSet<Product> Products { get; set; }
    
    // Represents the "Categories" table
    public DbSet<Category> Categories { get; set; }

    // Represents the "Quizzes" table
    public DbSet<Quiz> Quizzes { get; set; }

    // Represents the "Questions" table
    public DbSet<Question> Questions { get; set; }

    // Represents the "EducationalFiles" table
    public DbSet<EducationalFile> EducationalFiles { get; set; }

    // Represents the "Schedules" table
    public DbSet<Schedule> Schedules { get; set; }

    // Represents the "Articles" table
    public DbSet<Article> Articles { get; set; }

    // Represents the "Users" table for Admin Panel login
    public DbSet<User> Users { get; set; }
}
