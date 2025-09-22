
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Database;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    // Configure the database connection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // SQLite database file stored locally
            var dbPath = Path.Combine(AppContext.BaseDirectory, "library.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }

    // Configure entity mappings (optional, can be extended later)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(b => b.Id);  // Primary key
            entity.Property(b => b.Title).IsRequired().HasMaxLength(200);
            entity.Property(b => b.Author).IsRequired().HasMaxLength(100);
            entity.Property(b => b.Genre).HasMaxLength(50);
        });
    }


}
