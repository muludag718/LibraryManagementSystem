
namespace LibraryManagementSystem.Models;

public class Book 
{ 
    // Primary Key (auto-incremented by the database)
    public int Id { get; set; }

    // Book title
    public string Title { get; set; } = string.Empty;

    // Author name
    public string Author { get; set; } = string.Empty;

    // Publication year (nullable, not always available)
    public int? Year { get; set; }

    // Genre or category (e.g., Novel, Science, History)
    public string Genre { get; set; } = string.Empty;

    // Whether the book is currently borrowed
    public bool IsBorrowed { get; set; } = false;

    // Date when the book was borrowed (nullable)
    public DateTime? BorrowedDate { get; set; } = null;

    // Who borrowed the book (optional, can be stored as string for now)
    public string? BorrowedBy { get; set; } = string.Empty;

  
}
