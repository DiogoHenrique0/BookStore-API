using BookStore.Entities;

namespace BookStore.Repositories;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _books = new();

    public void Add(Book book)
    {
        _books.Add(book);
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public Book? GetById(Guid id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public Book? GetByTitleAndAuthor(string title, string author)
    {
        return _books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
    }

    public void Update(Book book)
    {
       
    }

    public void Delete(Book book)
    {
        _books.Remove(book);
    }
}
