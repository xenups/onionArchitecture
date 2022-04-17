using MediatR;

namespace Book.Core.Contracts.Book
{
    public class AddCommand : IRequest<AddResponse>
    {
        public string Name { get; set; }
    }
}