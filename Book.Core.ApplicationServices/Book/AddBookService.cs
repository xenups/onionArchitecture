using BookApp.Core.Contracts.Books;
using BookApp.Core.Domain;
using MediatR;

namespace BookApp.Core.ApplicationServices.Books
{

    public class AddBookService : IRequestHandler<AddBookCommand, AddResponse>
    {
        private readonly IBookRepository _bookRepository;
        public AddBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        public async Task<AddResponse> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            Book book = new()
            {
                CreatedDate = DateTime.UtcNow,
                Name = request.Name,
            };
            _bookRepository.Add(book);

            return new AddResponse() { Id = book.Id, Name = book.Name, CreatedDate = book.CreatedDate };
        }
    }
}
