using Library.Models;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public BookModel? Get(int id) => _context.Books.FirstOrDefault(x => x.Id == id);

        public IEnumerable<BookModel?> GetAll() => _context.Books.ToList();

        public void Add(BookModel? newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
        }

        public void Update(int id, BookModel newBook)
        {
            var existingBook = _context.Books.FirstOrDefault(x => x.Id == id);
            if (existingBook == null) return;

            existingBook.Author = newBook.Author;
            existingBook.Title = newBook.Title;
            existingBook.IsAvailable = newBook.IsAvailable;
            _context.Books.Entry(existingBook).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);

            if (book == null) return;

            _context.Books.Remove(book);
            _context.SaveChanges();
            }
    }
}
