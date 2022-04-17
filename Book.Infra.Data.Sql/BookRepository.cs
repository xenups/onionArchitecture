using Book.Core.Contracts.Book;
using Book.Core.Domain;

namespace Book.Infra.Data.Sql
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _bookContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookContext = bookDbContext;
        }
        public void AddBook(BookDomain book)
        {
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
        }
        public BookDomain GetBook(long BookId)
        {
            return _bookContext.Books.Where(b => b.Id == BookId).SingleOrDefault();
        }
        public IEnumerable<BookDomain> GetBooks()
        {
            IEnumerable<BookDomain> books = _bookContext.Books.ToList();
            return books;
        }
        public void DeleteBook(BookDomain book)
        {
            _bookContext.Books.Remove(book);
            _bookContext.SaveChanges(true);
        }
    }
}