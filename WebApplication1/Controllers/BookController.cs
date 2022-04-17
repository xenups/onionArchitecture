using Book.Core.ApplicationServices.Book;
using Book.Core.Contracts.Book;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult AddBookController([FromQuery] string bookName)
        {
            var response = _mediator.Send(new AddCommand() { Name = bookName });
            //AddBookInput bookInput = new AddBookInput() { Name = bookName };
            //AddBookOutput bookOutput = _mediator.Execute(bookInput);
            return base.Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
