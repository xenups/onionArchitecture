using AutoMapper;
using BookApp.Core.Contracts.Books;
using MediatR;

namespace BookApp.Core.ApplicationServices.Books
{
    public class RetrieveBookService : IRequestHandler<RetriveCommand, RetriveResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public RetrieveBookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<RetriveResponse> Handle(RetriveCommand request, CancellationToken cancellationToken)
        {
            var book = _bookRepository.GetBook(request.Id);
            RetriveResponse addResponse = _mapper.Map<RetriveResponse>(book);
            return addResponse;
        }
    }
}
