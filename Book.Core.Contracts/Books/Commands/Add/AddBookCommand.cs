using MediatR;

namespace BookApp.Core.Contracts.Books
{
    public class AddBookCommand : IRequest<AddResponse>
    {
        public string Name { get; set; }
    }
}