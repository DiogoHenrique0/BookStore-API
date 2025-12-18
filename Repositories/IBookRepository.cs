using BookStore.Entities;

namespace BookStore.Repositories;

public interface IBookRepository
{
    void Add(Book book);
    List<Book> GetAll();
    Book? GetById(Guid id);
    Book? GetByTitleAndAuthor(string title, string author);
    void Update(Book book);
    void Delete(Book book);
}
