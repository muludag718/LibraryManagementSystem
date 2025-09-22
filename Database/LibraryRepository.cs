
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Database;

public class LibraryRepository : IDisposable
{
    private readonly LibraryDbContext _context;

    public LibraryRepository()
    {
        _context = new LibraryDbContext();
        _context.Database.EnsureCreated();
    }


    public List<Book> GetAllBooks()
    {
        return [.. _context.Books];
    }

    public Book? GetBookById(int id)
    {
        return _context.Books.Find(id);
    }


    public void AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }


    public void UpdateBook(Book book)
    {
        var existingBook = _context.Books.Find(book.Id) ?? throw new InvalidOperationException("Book not found in the database.");
        _context.Entry(existingBook).CurrentValues.SetValues(book);
        _context.SaveChanges();
    }

    public void DeleteBook(int id)
    {
        var book = GetBookById(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }


    public List<Book> SearchBooks(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return GetAllBooks();
        }

        string lowerKeyword = keyword.ToLower();
        return [.. _context.Books
            .Where(b =>
                (b.Title != null && b.Title.ToLower().Contains(lowerKeyword)) ||
                (b.Author != null && b.Author.ToLower().Contains(lowerKeyword))||
                (b.Genre != null && b.Genre.ToLower().Contains(lowerKeyword))

            )];
    }

    private bool disposed = false;


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            _context.Dispose();
        }
        disposed = true;
    }

    ~LibraryRepository()
    {
        Dispose(false);
    }
}
