using Book.Core.Domain;

namespace Book.Core.Contracts.Book
{
    public interface IBookRepository
    {
        void AddBook(BookDomain book);
        void DeleteBook(BookDomain book);
        BookDomain GetBook(long BookId);
        IEnumerable<BookDomain> GetBooks();
    }
}