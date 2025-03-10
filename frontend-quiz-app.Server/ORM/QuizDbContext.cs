using frontend_quiz_app.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace frontend_quiz_app.Server.ORM
{
    public class QuizDbContext : DbContext
    {
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<QuizCategory> QuizCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "quiz.db");
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuizDbContext).Assembly);
        }
     }
}
