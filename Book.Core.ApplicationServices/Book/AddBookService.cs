using AutoMapper;
using BookApp.Core.Contracts.Books;
using BookApp.Core.Domain;
using MediatR;

namespace BookApp.Core.ApplicationServices.Books
{
    public class AddBookService : IRequestHandler<AddBookCommand, AddResponse>
    {
        private readonly IMapper _mapper;

        private readonly IBookRepository _bookRepository;

        public AddBookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<AddResponse> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            Book book = _mapper.Map<Book>(request);
            _bookRepository.Add(book);
            AddResponse addResponse = _mapper.Map<AddResponse>(book);
            return addResponse;
        }
    }
}
