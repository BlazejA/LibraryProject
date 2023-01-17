using Library.Models;

namespace Library.Repository;

public interface IBookRepository
{
    BookModel? Get(int id);
    IEnumerable<BookModel?> GetAll();
    void Add(BookModel? task);
    void Update(int id, BookModel task);
    void Delete(int id);
}