using Book.Core.Contracts.Book;

namespace Book.Core.ApplicationServices.Book
{
    public interface IAddBookService
    {
        AddBookOutput Execute(AddBookInput addBookInput);
    }
}