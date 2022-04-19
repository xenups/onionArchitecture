using AutoMapper;
using BookApp.Core.Contracts.Books;
using BookApp.Core.Domain;

namespace BookApp.Core.Contracts
{

    public class BookMapperProfile : Profile
    {
        public BookMapperProfile()
        {
            CreateMap<Book, AddResponse>();
            CreateMap<AddBookCommand, Book>();
            CreateMap<RetriveResponse, Book>();
        }
    }
}
