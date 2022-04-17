using BookApp.Core.Contracts.Books;
using BookApp.Core.Domain;

namespace BookApp.Infra.Data.Sql
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _bookContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookContext = bookDbContext;
        }
        public void Add(Core.Domain.Book book)
        {
            Console.WriteLine("hiiiiiiiiiiiiiiii");
            Console.WriteLine(book.Name);
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
        }
        public Core.Domain.Book GetBook(long BookId)
        {
            return _bookContext.Books.Where(b => b.Id == BookId).SingleOrDefault();
        }
        public IEnumerable<Core.Domain.Book> GetBooks()
        {
            IEnumerable<Core.Domain.Book> books = _bookContext.Books.ToList();
            return books;
        }
        public void DeleteBook(Core.Domain.Book book)
        {
            _bookContext.Books.Remove(book);
            _bookContext.SaveChanges(true);
        }
    }
}