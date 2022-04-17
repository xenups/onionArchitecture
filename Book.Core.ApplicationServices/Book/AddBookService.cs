using Book.Core.Contracts.Book;
using Book.Core.Domain;
using Book.Infra.Data.Sql;

namespace Book.Core.ApplicationServices.Book
{
    public class AddBookService : IAddBookService
    {
        private readonly IBookRepository _bookRepository;
        public AddBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public AddBookOutput Execute(AddBookInput addBookInput)
        {
            BookDomain book = new BookDomain()
            {
                CreatedDate = DateTime.UtcNow,
                Name = addBookInput.Name,
            };
            _bookRepository.AddBook(book);
            AddBookOutput output = new AddBookOutput() { Name = book.Name, Id = book.Id, CreatedDate = book.CreatedDate };
            return output;

        }
    }
}
