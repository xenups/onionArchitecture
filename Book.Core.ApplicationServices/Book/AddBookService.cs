using Book.Core.Contracts.Book;
using Book.Core.Domain;
using MediatR;

namespace Book.Core.ApplicationServices.Book
{

    public class AddBookService : IRequestHandler<AddCommand, AddResponse>
    {
        private readonly IBookRepository _bookRepository;
        public AddBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<AddResponse> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            BookD book = new BookD()
            {
                CreatedDate = DateTime.UtcNow,
                Name = request.Name,
            };
            _bookRepository.Add(book);
            return new AddResponse() { Id = book.Id, Name = book.Name, CreatedDate = book.CreatedDate };
        }
    }
}
