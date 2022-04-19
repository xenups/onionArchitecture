using MediatR;

namespace BookApp.Core.Contracts.Books
{
    public class RetriveCommand : IRequest<RetriveResponse>
    {
        public long Id { get; set; }
    }
}