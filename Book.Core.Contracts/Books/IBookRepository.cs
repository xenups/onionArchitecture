using BookApp.Core.Domain;

namespace BookApp.Core.Contracts.Books
{
    public interface IBookRepository
    {
        void Add(Book book);
        void DeleteBook(Book book);
        Book GetBook(long BookId);
        IEnumerable<Book> GetBooks();
    }

}
