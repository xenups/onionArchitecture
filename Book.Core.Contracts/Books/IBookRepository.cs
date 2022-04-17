using BookApp.Core.Domain;

namespace BookApp.Core.Contracts.Books
{
    public interface IBookRepository
    {
        void Add(Domain.Book book);
        void DeleteBook(Domain.Book book);
        Domain.Book GetBook(long BookId);
        IEnumerable<Domain.Book> GetBooks();
    }
}