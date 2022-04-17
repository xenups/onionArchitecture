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
        public void Add(Core.Domain.BookD book)
        {
            Console.WriteLine("hiiiiiiiiiiiiiiii");
            Console.WriteLine(book.Name);
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
        }
        public Core.Domain.BookD GetBook(long BookId)
        {
            return _bookContext.Books.Where(b => b.Id == BookId).SingleOrDefault();
        }
        public IEnumerable<Core.Domain.BookD> GetBooks()
        {
            IEnumerable<Core.Domain.BookD> books = _bookContext.Books.ToList();
            return books;
        }
        public void DeleteBook(Core.Domain.BookD book)
        {
            _bookContext.Books.Remove(book);
            _bookContext.SaveChanges(true);
        }
    }
}