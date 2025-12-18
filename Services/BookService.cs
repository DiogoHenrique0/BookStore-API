using BookStore.DTOs;
using BookStore.Entities;
using BookStore.Repositories;

namespace BookStore.Services;

public class BookService
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public List<Book> GetAll()
    {
        return _repository.GetAll();
    }


    public Book Create(CreateBookDto dto)
    {
        var existingBook = _repository.GetByTitleAndAuthor(dto.Title, dto.Author);

        if (existingBook != null)
            throw new InvalidOperationException("Book already exists.");

        var book = new Book(
            dto.Title,
            dto.Author,
            dto.Genre,
            dto.Price,
            dto.Stock
            );

        _repository.Add(book);

        return book;
    }

    public Book GetById(Guid id)
    {
        var book = _repository.GetById(id);

        if (book == null)
            throw new KeyNotFoundException("Book not found.");

        return book;
    }

    public void Update(Guid id, UpdateBookDto dto)
    {
        var book = _repository.GetById(id);

        if (book == null)
            throw new KeyNotFoundException("Book not found.");

        var duplicated = _repository.GetByTitleAndAuthor(dto.Title, dto.Author);

        if (duplicated != null && duplicated.Id != id)
            throw new InvalidOperationException("Book already exists.");

        book.Update(
            dto.Title,
            dto.Author,
            dto.Genre,
            dto.Price,
            dto.Stock
            );

        _repository.Update(book);
    }

    public void Delete(Guid id)
    {
        var book = _repository.GetById(id);

        if (book == null)
            throw new KeyNotFoundException("Book not found.");

        _repository.Delete(book);
    }
}
