using Book.Core.Domain;

namespace Book.Core.Contracts.Book
{
    public interface IBookRepository
    {
        void Add(Domain.BookD book);
        void DeleteBook(BookD book);
        Domain.BookD GetBook(long BookId);
        IEnumerable<BookD> GetBooks();
    }
}