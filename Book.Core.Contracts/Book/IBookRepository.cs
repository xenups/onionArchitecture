using Book.Core.Domain;

namespace Book.Core.Contracts.Book
{
    public interface IBookRepository
    {
        void Add(Domain.Book book);
        void DeleteBook(Domain.Book book);
        Domain.Book GetBook(long BookId);
        IEnumerable<Domain.Book> GetBooks();
    }
}